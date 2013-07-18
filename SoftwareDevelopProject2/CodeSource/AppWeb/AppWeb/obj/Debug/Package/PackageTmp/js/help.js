/*global window, jQuery */
/*Author: Ernesto Villarreal */
(function (exports, $) {
    var 
        $linkContainer,
        $contentContainer,
        $placeholder,
        currentHash = '',

        help = {
            init: function (linkContainer, contentContainer, placeholder) {
                var help = this;

                $linkContainer = $(linkContainer);
                $contentContainer = $(contentContainer);
                $placeholder = $(placeholder);
                this.hideAll(0);

                $linkContainer.find("li > a").each(function () {
                    $(this).on('click', function (e) {
                        var hash = $(this).attr("href");

                        e.preventDefault();

                        if (currentHash === hash) {
                            return;
                        }

                        help.hideAll(500);
                        help.show(hash);
                    });
                });
            },
            show: function (hash) {
                $placeholder.hide(500);
                $(hash).slideDown(500);
                currentHash = hash;
            },
            hide: function (hash) {
                $(hash).hide(500)
            },
            hideAll: function (speed) {
                this.containers().hide(speed);
            },
            containers: function () {
                return $contentContainer.children("div").not($placeholder);
            }
        };

    exports.help = help;
} (window.SCS, jQuery));
