var PostsController = function ($scope, PostFactory) {


    $scope.newPost = {};
    //    title: "ee",
    //    article: " ",
    //    titleClean: " ",
    //    file: " ",
    //    authorId: " ",
    //    datePublished: " ",
    //    bannerImage: " ",
    //    featured: " ",
    //    enabled: " ",
    //    commentsEnabled: " ",
    //    views: " "


    //}
    $scope.posts = {};
    PostFactory.getPosts().then(function (data) { $scope.posts = data;});

    console.log($scope.posts,'sssss');


    $scope.saveNewPost = function (o) {
        o.article = $("#postArticle").val();
        console.log("oooooooooooo", o);


        PostFactory.saveNewPost(o)
        //.then(function (result) {console.log(result);})


    }
    $scope.getPosts= function () {
        //o.article = $("#postArticle").val();
        //console.log("oooooooooooo", o);


        PostFactory.getPosts()
        //.then(function (result) {console.log(result);})


    }
   
    //$scope.getPosts();

}

// The $inject property of every controller (and pretty much every other type of object in Angular) needs to be a string array equal to the controllers arguments, only as strings
PostsController.$inject = ['$scope', 'PostFactory'];