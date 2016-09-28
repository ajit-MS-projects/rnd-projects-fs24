var myApp = angular.module('myApp', []);

myApp.controller('mainController', ['$scope', '$filter','$timeout','$location', function($scope, $filter, $timeout, $location) {
    
    $scope.handle = '';
    $scope.classDeterminator = 'alert-danger';
        
    $scope.lowercasehandle = function() {
        return $filter('lowercase')($scope.handle);
    };
    
    $scope.characters = 5;
    
    $scope.rules = [
      
        { rulename: "Must be 5 characters" },
        { rulename: "Must not be used elsewhere" },
        { rulename: "Must be cool" }
        
    ];
    
    console.log($scope.rules);
    
    $scope.classDeterminator1 = { 'alert-warning': $scope.handle.length < $scope.characters, 'alert-danger': $scope.handle.length > $scope.characters };
    
    $scope.classDeterminator2 = function()
    {
        return 'alert-danger';
        return $scope.handle.length < $scope.characters ? 'alert-warning': 'alert-danger';
    }
    
    window.location.hash = "dddd";
    $timeout(function(){
        alert($location.path());
        window.location.hash = "xxxx";
    }, 5000);
}]);
