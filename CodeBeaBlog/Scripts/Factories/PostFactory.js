var PostFactory = function ($q, $http) {
    return {
        saveNewPost: function (AAAA) {
            // Simple GET request example:



            $http({

                method: 'POST',
                url: '/Admin/SaveNewPost',
                data: AAAA,
                //headers: { "Content-Type": "application/json" },
                dataType: "json",

            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
            }, function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
            ;
        }, getPosts: function () {
            var result = $q.defer();

            // Simple GET request example:
            $http({
                method: 'POST',
                url: '/Blog/GetPosts',
                //data: AAAA,
                //headers: { "Content-Type": "application/json" },
                dataType: "json",

            }).success(function (response) {
                result.resolve(response);
            })
  .error(function (response) {
      result.reject(response);
  });
            return result.promise;

            ;
        }

    }
}

PostFactory.$inject = ['$q', '$http'];





//var PostFactory = function ($q, $location) {
//    return {
//        response: function (response) {
//            if (response.status === 401) {
//                console.log("Response 401");
//            }
//            return response || $q.when(response);
//        },
//        responseError: function (rejection) {
//            if (rejection.status === 401) {
//                console.log("Response Error 401", rejection);
//                $location.path('/login').search('returnUrl', $location.path());
//            }
//            return $q.reject(rejection);
//        }
//    }
//}

//PostFactory.$inject = ['$q', '$location'];
