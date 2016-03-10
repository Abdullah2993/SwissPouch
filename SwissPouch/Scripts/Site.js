ko.components.register("owsv", {
    template: '<div class="row"><div class="panel panel-default"><div class="panel-heading"><h3 class="panel-title" data-bind="text: title"></h3></div><div class="form-group padded"><textarea class="form-control" rows="3" data-bind="value: text"></textarea><div class="paddedtop"><button class="btn btn-default" data-bind="text: buttonLabel, click: getData"></button></div></div></div></div>',
    viewModel: function(params) {
        var self = this;
        self.title = params.title;
        self.buttonLabel = params.buttonLabel;
        self.link = params.link;
        self.text = ko.observable();
        self.method = params.method;
        self.getData = function () {
            var selfData;
            if (self.method === "GET") {
                selfData = "data=" + self.text();
            }else{
                selfData = JSON.stringify(self.text());
            }

            $.ajax({
                url: self.link,
                method: self.method,
                data: selfData ,
                processData: false,
                contentType: "application/json",
                dataType: "json"
            }).done(function(data) {
                self.text(data);
            });
        };
    }
});

ko.components.register("twsv", {
    template: "<h1>Hello 3</h1>",
    viewModel: function () {

    }
});

ko.applyBindings();