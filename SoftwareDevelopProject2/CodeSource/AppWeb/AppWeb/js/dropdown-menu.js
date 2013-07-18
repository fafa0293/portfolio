/*global window, jQuery */
/*Author: Ernesto Villarreal */
(function (exports, $) {
    var userMenu = (function () {
        var dropdownButton,
            menu,

            dropdownMenu = {
                init: function () {
                    dropdownButton = $("#user-dropdown-menu-link");
                    menu = $("#user-dropdown-menu");

                    dropdownButton.on('click', dropdownMenu.toggle);

                    $(document).on('mouseup', function (e) {
                        if ($(e.target).parents("#user-dropdown-menu").length === 0 && $(e.target).filter("#user-dropdown-menu").length === 0) {
                            userMenu.hide();
                        }
                    });

                },
                show: function (e) {
                    if (e) {
                        e.preventDefault();
                    }
                    menu.css({
                        top: dropdownButton.parent().height(),
                        left: dropdownButton.offset().left,
                        width: Math.max(140, dropdownButton.width())
                    });
                    menu.slideDown('fast');
                },
                hide: function () {
                    menu.slideUp('fast');
                },
                toggle: function (e) {
                    if (menu.is(":visible")) {
                        dropdownMenu.hide(e);
                    } else {
                        dropdownMenu.show(e);
                    }
                }
            };

        return dropdownMenu;
    } ());

    exports.userMenu = userMenu;
} (window.SCS, jQuery));
