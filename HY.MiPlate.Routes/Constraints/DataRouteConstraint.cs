namespace HY.MiPlate.Routes.Constraints
{
    using System.Web.Routing;
    public class DataRouteConstraint : IRouteConstraint
    {
        public bool Match(System.Web.HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return values.ContainsKey(parameterName) && values[parameterName].Equals("data");
        }
    }
}
