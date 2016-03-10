ko.components.register("owsv", {
    template: '<div class="row"><div class="panel panel-default"><div class="panel-heading"><h3 class="panel-title" data-bind="text: title"></h3></div><div class="form-group padded"><textarea class="form-control" rows="3" data-bind="value: text,attr:{placeholder: placeHolder}"></textarea><div class="paddedtop"><button class="btn btn-default" data-bind="text: buttonLabel, click: getData"></button></div></div></div></div>',
    viewModel: function (params) {
        var self = this;
        self.title = params.title;
        self.buttonLabel = params.buttonLabel;
        self.link = params.link;
        self.text = ko.observable();
        self.method = params.method;
        self.placeHolder = params.placeHolder;
        self.getData = function () {
            if (self.text() == undefined) {
                return;
            }
            var selfData;
            if (self.method === "GET") {
                selfData = "data=" + self.text();
            } else {
                selfData = JSON.stringify(self.text());
            }

            $.ajax({
                url: self.link,
                method: self.method,
                data: selfData,
                processData: false,
                contentType: "application/json",
                dataType: "json"
            }).done(function (data) {
                self.text(data);
            });
        };
    }
});

ko.components.register("twsv", {
    template: '<div class="row"><div class="panel panel-default"><div class="panel-heading"><h3 class="panel-title" data-bind="text: title"></h3></div><div class="form-group padded"><textarea class="form-control" rows="3" data-bind="value: text,attr:{placeholder: placeHolder}"></textarea><div class="paddedtop"><button class="btn btn-default" data-bind="text: buttonLabel1, click: getData1"></button><button class="btn btn-default" style="margin-left: 5px;" data-bind="text: buttonLabel2, click: getData2"></button></div></div></div></div>',
    viewModel: function (params) {
        var self = this;
        self.title = params.title;
        self.buttonLabel1 = params.buttonLabel1;
        self.buttonLabel2 = params.buttonLabel2;
        self.link = params.link;
        self.text = ko.observable();
        self.method = params.method;
        self.placeHolder = params.placeHolder;
        self.getData1 = function () {
            if (self.text() == undefined) {
                return;
            }
            var selfData;
            if (self.method === "GET") {
                selfData = "data=" + self.text();
            } else {
                selfData = JSON.stringify(self.text());
            }

            $.ajax({
                url: self.link + "?id=1",
                method: self.method,
                data: selfData,
                processData: false,
                contentType: "application/json",
                dataType: "json"
            }).done(function (data) {
                self.text(data);
            });
        };
        self.getData2 = function () {
            if (self.text() == undefined) {
                return;
            }
            var selfData;
            if (self.method === "GET") {
                selfData = "data=" + self.text();
            } else {
                selfData = JSON.stringify(self.text());
            }

            $.ajax({
                url: self.link + "?id=2",
                method: self.method,
                data: selfData,
                processData: false,
                contentType: "application/json",
                dataType: "json"
            }).done(function (data) {
                self.text(data);
            });
        };
    }
});

ko.applyBindings();