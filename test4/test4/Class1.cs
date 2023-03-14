using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test4
{

    public interface ITriangleValidateService
    {
        bool IsAllValid();
        bool IsValid(long id);
    }

    public interface ITriangleProvider
    {
        Triangle GetById(long id);
        List<Triangle> GetAll();
        void save(Triangle triangle);
    }

    public interface ITriangleService
    {
        bool Valid(double a, double b, double c);
        string GetType(double a, double b, double c);
        double GetArea(double a, double b, double c);
    }

    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public string type;
        public double square;
        public long id;

        public Triangle()
        {

        }

        public Triangle(double A, double B, double C, string Type, double Square, long Id)
        {
            a = A;
            b = B;
            c = C;
            type = Type;
            square = Square;
            id = Id;
        }
    }
    public class TriangleValidateService : ITriangleValidateService
    {
        private readonly ITriangleProvider TriangleProvider;
        private readonly ITriangleService TriangleService;

        public TriangleValidateService(ITriangleProvider TriangleProvider, ITriangleService TriangleService)
        {
            this.TriangleProvider = TriangleProvider;
            this.TriangleService = TriangleService;
        }

        public bool IsAllValid()
        {
            List<Triangle> list = TriangleProvider.GetAll();
            bool x = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (TriangleService.Valid(list[i].a, list[i].b, list[i].c) == false)
                {
                    x = false;
                    break;
                }
            }
            return x;
        }

        public bool IsValid(long id)
        {
            Triangle tr = TriangleProvider.GetById(id);
            bool x = TriangleService.Valid(tr.a, tr.b, tr.c);
            return x;
        }
    }

    public class TriangleProvider : ITriangleProvider
    {
        private readonly string path;
        public TriangleProvider(string path)
        {
            this.path = path;
        }
        public Triangle GetById(long id)
        {
            Triangle tr = new Triangle();
            using (var con = new NpgsqlConnection(path))
            {
                con.Open();
                string sql = $"SELECT * FROM Triangles WHERE id = {id}";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tr = new Triangle(
                         reader.GetDouble(reader.GetOrdinal("A")),
                         reader.GetDouble(reader.GetOrdinal("B")),
                         reader.GetDouble(reader.GetOrdinal("C")),
                         reader.GetString(reader.GetOrdinal("Type")),
                         reader.GetDouble(reader.GetOrdinal("Square")),
                         reader.GetInt64(reader.GetOrdinal("id"))
                         );
                }
            }
            return tr;
        }

        public List<Triangle> GetAll()
        {
            List<Triangle> triangle = new List<Triangle>();
            using (var con = new NpgsqlConnection())
            {
                con.Open();
                string sql = $"SELECT * FROM Triangles";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    triangle.Add(new Triangle(
                         reader.GetDouble(reader.GetOrdinal("A")),
                         reader.GetDouble(reader.GetOrdinal("B")),
                         reader.GetDouble(reader.GetOrdinal("C")),
                         reader.GetString(reader.GetOrdinal("Type")),
                         reader.GetDouble(reader.GetOrdinal("Square")),
                         reader.GetInt64(reader.GetOrdinal("id"))
                         ));
                }
            }
            return triangle;
        }

        public void save(Triangle triangle)
        {
            using (var con = new NpgsqlConnection(path))
            {
                con.Open();
                var cmd = new NpgsqlCommand();
                cmd.CommandText = $"INSERT INTO Triangles VALUES({triangle.a}, {triangle.b}, {triangle.c}, {triangle.type},{triangle.square},{triangle.id})";
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            
        }
    }

    public class TriangleService : ITriangleService
    {
        public bool Valid(double a, double b, double c)
        {
            bool x = true;
            if (a <= 0 || b <= 0 || c <= 0)
            {
                x = false;
            }
            if (a + b < c || b + c < a || c + a < b)
            {
                x = false;
            }
            return x;
        }

        public string GetType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "равносторонний";
            }
            else if (a == b || b == c || c == a)
            {
                return "равнобедренный";
            }
            else
            {
                return "разносторонний";
            }
        }

        public double GetArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}
