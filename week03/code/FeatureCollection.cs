public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // I need to structure the json as a class for the program to work...
    public string Type{get; set; }
    public List<Feature> Features{get; set; }

    public string Id {get; set; }



    public class Feature{
        public string Type{get; set; }
        public Properties Properties{get; set; }
        public Geometry Geometry{get; set; }
        public string Id {get; set; }
    }
    public class Properties{
      
            public double Mag { get; set; }
            public string Place { get; set; }
        }

    public class Geometry{
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }


}