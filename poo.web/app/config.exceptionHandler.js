// Include in index.html so that app level exceptions are handled.
(function () {
    'use strict';

    var app = angular.module('app');

    // Configure by setting an optional string value for appErrorPrefix.
    // Accessible via config.appErrorPrefix (via config value).

    app.config(['$provide', function ($provide) {
        $provide.decorator('$exceptionHandler',
            ['$delegate', 'config', 'logger', extendExceptionHandler]);
    }]);

    // Extend the $exceptionHandler service to also display a notification for all errors.
    function extendExceptionHandler($delegate, config, logger) {
        var errorPrefix = config.errorPrefix;
        var logError = logger.getLogFn('app', 'error');
        return function (exception, cause) {
            $delegate(exception, cause);
            if (errorPrefix && exception.message.indexOf(errorPrefix) === 0) { return; }

            var errorData = { exception: exception, cause: cause };
            var msg = errorPrefix + exception.message;
            logError(msg, errorData, true);
        };
    }
})();