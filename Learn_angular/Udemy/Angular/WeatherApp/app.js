var myApp = angular.module('weatherApp',['ngRoute', 'ngResource']);

myApp.config(function($routeProvider){
   
    $routeProvider.when('/',{
        templateUrl: 'pages/home.htm',
        controller: 'homeController'})
    .when('/forecast',{
        templateUrl:'/pages/forecast.htm',
        controller:'forecastController'
    });
                        
});

myApp.service('weatherService',function(){
    this.city = "Munich,de";
});

myApp.controller("homeController", ['$http','$scope','weatherService', '$location',function($http, $scope, weatherService, $location) {
    $scope.city = weatherService.city;
    $scope.$watch('city', function(){
        weatherService.city=$scope.city;
    });
    
    $scope.getCityForecast = function()
    {
        $location.path("/forecast");
    }
    
}]);

myApp.controller("forecastController", ['$http','$scope', 'weatherService',function($http, $scope, weatherService) {
   
    $scope.city = weatherService.city;
    $http.get("http://api.openweathermap.org/data/2.5/forecast/daily?cnt=16&q="+ $scope.city)
    .success(function(result) {
        console.log(result);
        $scope.weatherResult = result;
    })
    .error(function(result){
        alert("errr:" + result);
    });
    
    
    $scope.convertToFahrenheit = function(degK) {
        
        return Math.round((1.8 * (degK - 273)) + 32);
        
    }
     
     $scope.convertToCelsius = function(degK) {
        
        return Math.round(degK - 273);
        
    }
    
    $scope.convertToDate = function(dt) { 
      
        return new Date(dt * 1000);
        
    };
    
}]);