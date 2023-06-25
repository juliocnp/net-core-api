
namespace Order.Domain.Validation.Base
{
    public class Response
    {
        public Response() 
        { 
            Report = new List<Report>();
        }
        public Response(List<Report>? report)
        {
            Report = report;
        }
        public Response (Report report) : this(new List<Report>() { report }) 
        {

        }
        public List<Report>? Report { get; set; }

        public static Response<T> Ok<T>(T data) => new Response<T>(data);
        public static Response Ok() => new Response();
        public static Response<T> NotOk<T>(Report report) => new Response<T>(report);
        public static Response NotOk(List<Report> reports) => new Response(reports);
        public static Response NotOk(Report report) => new Response(report);
    }

    public class Response<T> : Response
    {
        public Response()
        {

        }
        public Response(Report report) : base(report) { }
        public Response(List<Report> report) : base(report) { }
        public Response(T data)
        {
            Data = data;
        }
        public T? Data { get; set; }
    }
}
