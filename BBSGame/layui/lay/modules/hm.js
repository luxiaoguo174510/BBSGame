﻿(function () {
    var h = {}, mt = {}, c = { id: "d214947968792b839fd669a4decaaffc", dm: ["layui.com", "layuicdn.com"], js: "tongji.baidu.com/hm-web/js/", etrk: [{ id: "%23layui-spm-event-layuicdn", eventType: "onclick" }, { id: "%23fly-spm-event-banner-1", eventType: "onclick" }, { id: "%23fly-spm-event-banner-2", eventType: "onclick" }, { id: "%23fly-spm-event-diamonds-1", eventType: "onclick" }, { id: "%23layui-spm-event-parter", eventType: "onclick" }, { id: "%23layui-spm-event-zb-xiankefu", eventType: "onclick" }, { id: "%23layui-spm-event-xiankefu", eventType: "onclick" }, { id: "%23fly-spm-event-banner-xiankefu", eventType: "onclick" }, { id: "%23layui-spm-event-parter-tips", eventType: "onclick" }, { id: "%23layer-spm-event-parter", eventType: "onclick" }, { id: "%23layer-spm-event-parter-tips", eventType: "onclick" }], cetrk: [], cptrk: [], icon: '', ctrk: false, align: -1, nv: 0, vdur: 1800000, age: 31536000000, rec: 0, rp: [], trust: 0, vcard: 0, qiao: 0, lxb: 0, kbtrk: 0, pt: 0, spa: 0, aet: '', hca: 'F095F35BB721FD10', conv: 0, med: 0, cvcc: '', cvcf: [], apps: '' }; var s = void 0, v = !0, w = null, x = !1; mt.cookie = {}; mt.cookie.set = function (a, e, b) { var d; b.S && (d = new Date, d.setTime(d.getTime() + b.S)); document.cookie = a + "=" + e + (b.domain ? "; domain=" + b.domain : "") + (b.path ? "; path=" + b.path : "") + (d ? "; expires=" + d.toGMTString() : "") + (b.Fc ? "; secure" : "") }; mt.cookie.get = function (a) { return (a = RegExp("(^| )" + a + "=([^;]*)(;|$)").exec(document.cookie)) ? a[2] : w };
    mt.cookie.ec = function (a, e) { try { var b = "Hm_ck_" + +new Date; mt.cookie.set(b, "is-cookie-enabled", { domain: a, path: e, S: s }); var d = "is-cookie-enabled" === mt.cookie.get(b) ? "1" : "0"; mt.cookie.set(b, "", { domain: a, path: e, S: -1 }); return d } catch (f) { return "0" } }; mt.lang = {}; mt.lang.e = function (a, e) { return "[object " + e + "]" === {}.toString.call(a) }; mt.lang.Ba = function (a) { return mt.lang.e(a, "Number") && isFinite(a) }; mt.lang.L = function (a) { return mt.lang.e(a, "String") }; mt.lang.isArray = function (a) { return mt.lang.e(a, "Array") };
    mt.lang.g = function (a) { return a.replace ? a.replace(/'/g, "'0").replace(/\*/g, "'1").replace(/!/g, "'2") : a }; mt.lang.trim = function (a) { return a.replace(/^\s+|\s+$/g, "") }; mt.lang.K = function (a, e) { var b = x; if (a == w || !mt.lang.e(a, "Array") || e === s) return b; if (Array.prototype.indexOf) b = -1 !== a.indexOf(e); else for (var d = 0; d < a.length; d++)if (a[d] === e) { b = v; break } return b }; mt.url = {}; mt.url.o = function (a, e) { var b = a.match(RegExp("(^|&|\\?|#)(" + e + ")=([^&#]*)(&|$|#)", "")); return b ? b[3] : w };
    mt.url.Dc = function (a) { return (a = a.match(/^(https?:)\/\//)) ? a[1] : w }; mt.url.Ib = function (a) { return (a = a.match(/^(https?:\/\/)?([^\/\?#]*)/)) ? a[2].replace(/.*@/, "") : w }; mt.url.U = function (a) { return (a = mt.url.Ib(a)) ? a.replace(/:\d+$/, "") : a }; mt.url.wa = function (a) { return (a = a.match(/^(https?:\/\/)?[^\/]*(.*)/)) ? a[2].replace(/[\?#].*/, "").replace(/^$/, "/") : w };
    (function () {
        var a = mt.lang, e = mt.url; mt.f = {}; mt.f.ba = function (b) { return document.getElementById(b) }; mt.f.Pa = function (b) {
            if (!b) return w; try {
                b = String(b); if (0 === b.indexOf("!HMCQ!")) return b; if (0 === b.indexOf("!HMCC!")) return document.querySelector(b.substring(6, b.length)); for (var d = b.split(">"), f = document.body, a = d.length - 1; 0 <= a; a--)if (-1 < d[a].indexOf("#")) { var e = d[a].split("#")[1]; (f = document.getElementById(e)) || (f = document.getElementById(decodeURIComponent(e))); d = d.splice(a + 1, d.length - (a + 1)); break } for (b =
                    0; f && b < d.length;) { var m = String(d[b]).toLowerCase(); if (!("html" === m || "body" === m)) { var a = 0, p = d[b].match(/\[(\d+)\]/i), e = []; if (p) a = p[1] - 1, m = m.split("[")[0]; else if (1 !== f.childNodes.length) { for (var r = 0, u = 0, q = f.childNodes.length; u < q; u++) { var t = f.childNodes[u]; 1 === t.nodeType && t.nodeName.toLowerCase() === m && r++; if (1 < r) return w } if (1 !== r) return w } for (r = 0; r < f.childNodes.length; r++)1 === f.childNodes[r].nodeType && f.childNodes[r].nodeName.toLowerCase() === m && e.push(f.childNodes[r]); if (!e[a]) return w; f = e[a] } b++ } return f
            } catch (g) { return w }
        };
        mt.f.wa = function (b, d) { var a = [], e = []; if (!b) return e; for (; b.parentNode != w;) { for (var k = 0, m = 0, p = b.parentNode.childNodes.length, r = 0; r < p; r++) { var u = b.parentNode.childNodes[r]; if (u.nodeName === b.nodeName && (k++ , u === b && (m = k), 0 < m && 1 < k)) break } if ((p = "" !== b.id) && d) { a.unshift("#" + encodeURIComponent(b.id)); break } else p && (p = "#" + encodeURIComponent(b.id), p = 0 < a.length ? p + ">" + a.join(">") : p, e.push(p)), a.unshift(encodeURIComponent(String(b.nodeName).toLowerCase()) + (1 < k ? "[" + m + "]" : "")); b = b.parentNode } e.push(a.join(">")); return e };
        mt.f.Ra = function (b) { return (b = mt.f.wa(b, v)) && b.length ? String(b[0]) : "" }; mt.f.Nb = function (b) { return mt.f.wa(b, x) }; mt.f.Db = function (b) { var d; for (d = "A"; (b = b.parentNode) && 1 == b.nodeType;)if (b.tagName == d) return b; return w }; mt.f.Fb = function (b) { return 9 === b.nodeType ? b : b.ownerDocument || b.document }; mt.f.Lb = function (b) {
            var d = { top: 0, left: 0 }; if (!b) return d; var a = mt.f.Fb(b).documentElement; "undefined" !== typeof b.getBoundingClientRect && (d = b.getBoundingClientRect()); return {
                top: d.top + (window.pageYOffset || a.scrollTop) -
                    (a.clientTop || 0), left: d.left + (window.pageXOffset || a.scrollLeft) - (a.clientLeft || 0)
            }
        }; mt.f.getAttribute = function (a, d) { var e = a.getAttribute && a.getAttribute(d) || w; if (!e && a.attributes && a.attributes.length) for (var l = a.attributes, k = l.length, m = 0; m < k; m++)l[m].nodeName === d && (e = l[m].nodeValue); return e }; mt.f.da = function (a) { var d = "document"; a.tagName !== s && (d = a.tagName); return d.toLowerCase() }; mt.f.Qb = function (b) {
            var d = ""; b.textContent ? d = a.trim(b.textContent) : b.innerText && (d = a.trim(b.innerText)); d && (d = d.replace(/\s+/g,
                " ").substring(0, 255)); return d
        }; mt.f.ua = function (b, d) {
            var f; a.L(b) && 0 === String(b).indexOf("!HMCQ!") ? (f = String(b), f = e.o(document.location.href, f.substring(6, f.length))) : a.L(b) || (f = mt.f.da(b), "input" === f && d && ("button" === b.type || "submit" === b.type) ? f = a.trim(b.value) || "" : "input" === f && !d && "password" !== b.type ? f = a.trim(b.value) || "" : "img" === f ? (f = mt.f.getAttribute, f = f(b, "alt") || f(b, "title") || f(b, "src")) : f = "body" === f || "html" === f ? ["(hm-default-content-for-", f, ")"].join("") : mt.f.Qb(b)); return String(f || "").substring(0,
                255)
        }; (function () {
            (mt.f.Ga = function () {
                function a() { if (!a.fa) { a.fa = v; for (var d = 0, e = l.length; d < e; d++)l[d]() } } function d() { try { document.documentElement.doScroll("left") } catch (e) { setTimeout(d, 1); return } a() } var e = x, l = [], k; document.addEventListener ? k = function () { document.removeEventListener("DOMContentLoaded", k, x); a() } : document.attachEvent && (k = function () { "complete" === document.readyState && (document.detachEvent("onreadystatechange", k), a()) }); (function () {
                    if (!e) if (e = v, "complete" === document.readyState) a.fa = v;
                    else if (document.addEventListener) document.addEventListener("DOMContentLoaded", k, x), window.addEventListener("load", a, x); else if (document.attachEvent) { document.attachEvent("onreadystatechange", k); window.attachEvent("onload", a); var m = x; try { m = window.frameElement == w } catch (p) { } document.documentElement.doScroll && m && d() }
                })(); return function (d) { a.fa ? d() : l.push(d) }
            }()).fa = x
        })(); return mt.f
    })(); mt.event = {};
    mt.event.d = function (a, e, b) { a.attachEvent ? a.attachEvent("on" + e, function (d) { b.call(a, d) }) : a.addEventListener && a.addEventListener(e, b, x) }; mt.event.preventDefault = function (a) { a.preventDefault ? a.preventDefault() : a.returnValue = x };
    (function () {
        var a = mt.event; mt.i = {}; mt.i.Aa = /msie (\d+\.\d+)/i.test(navigator.userAgent); mt.i.Jb = function () { if (document.documentMode) return document.documentMode; var a = /msie (\d+\.\d+)/i.exec(navigator.userAgent); return a ? +a[1] || 0 : 0 }; mt.i.cookieEnabled = navigator.cookieEnabled; mt.i.javaEnabled = navigator.javaEnabled(); mt.i.language = navigator.language || navigator.browserLanguage || navigator.systemLanguage || navigator.userLanguage || ""; mt.i.mc = (window.screen.width || 0) + "x" + (window.screen.height || 0); mt.i.colorDepth =
            window.screen.colorDepth || 0; mt.i.V = function () { var a; a = a || document; return parseInt(window.pageYOffset || a.documentElement.scrollTop || a.body && a.body.scrollTop || 0, 10) }; mt.i.J = function () { var a = document; return parseInt(window.innerHeight || a.documentElement.clientHeight || a.body && a.body.clientHeight || 0, 10) }; mt.i.orientation = 0; (function () {
                function e() {
                    var a = 0; window.orientation !== s && (a = window.orientation); screen && (screen.orientation && screen.orientation.angle !== s) && (a = screen.orientation.angle); mt.i.orientation =
                        a
                } e(); a.d(window, "orientationchange", e)
            })(); return mt.i
    })(); mt.s = {}; mt.s.parse = function (a) { return (new Function("return (" + a + ")"))() };
    mt.s.stringify = function () {
        function a(a) { /["\\\x00-\x1f]/.test(a) && (a = a.replace(/["\\\x00-\x1f]/g, function (a) { var d = b[a]; if (d) return d; d = a.charCodeAt(); return "\\u00" + Math.floor(d / 16).toString(16) + (d % 16).toString(16) })); return '"' + a + '"' } function e(a) { return 10 > a ? "0" + a : a } var b = { "\b": "\\b", "\t": "\\t", "\n": "\\n", "\f": "\\f", "\r": "\\r", '"': '\\"', "\\": "\\\\" }; return function (d) {
            switch (typeof d) {
                case "undefined": return "undefined"; case "number": return isFinite(d) ? String(d) : "null"; case "string": return a(d); case "boolean": return String(d);
                default: if (d === w) return "null"; if (d instanceof Array) { var b = ["["], l = d.length, k, m, p; for (m = 0; m < l; m++)switch (p = d[m], typeof p) { case "undefined": case "function": case "unknown": break; default: k && b.push(","), b.push(mt.s.stringify(p)), k = 1 }b.push("]"); return b.join("") } if (d instanceof Date) return '"' + d.getFullYear() + "-" + e(d.getMonth() + 1) + "-" + e(d.getDate()) + "T" + e(d.getHours()) + ":" + e(d.getMinutes()) + ":" + e(d.getSeconds()) + '"'; k = ["{"]; m = mt.s.stringify; for (l in d) if (Object.prototype.hasOwnProperty.call(d, l)) switch (p =
                    d[l], typeof p) { case "undefined": case "unknown": case "function": break; default: b && k.push(","), b = 1, k.push(m(l) + ":" + m(p)) }k.push("}"); return k.join("")
            }
        }
    }(); mt.localStorage = {}; mt.localStorage.ma = function () { if (!mt.localStorage.l) try { mt.localStorage.l = document.createElement("input"), mt.localStorage.l.type = "hidden", mt.localStorage.l.style.display = "none", mt.localStorage.l.addBehavior("#default#userData"), document.getElementsByTagName("head")[0].appendChild(mt.localStorage.l) } catch (a) { return x } return v };
    mt.localStorage.set = function (a, e, b) { var d = new Date; d.setTime(d.getTime() + b || 31536E6); try { window.localStorage ? (e = d.getTime() + "|" + e, window.localStorage.setItem(a, e)) : mt.localStorage.ma() && (mt.localStorage.l.expires = d.toUTCString(), mt.localStorage.l.load(document.location.hostname), mt.localStorage.l.setAttribute(a, e), mt.localStorage.l.save(document.location.hostname)) } catch (f) { } };
    mt.localStorage.get = function (a) { if (window.localStorage) { if (a = window.localStorage.getItem(a)) { var e = a.indexOf("|"), b = a.substring(0, e) - 0; if (b && b > (new Date).getTime()) return a.substring(e + 1) } } else if (mt.localStorage.ma()) try { return mt.localStorage.l.load(document.location.hostname), mt.localStorage.l.getAttribute(a) } catch (d) { } return w };
    mt.localStorage.remove = function (a) { if (window.localStorage) window.localStorage.removeItem(a); else if (mt.localStorage.ma()) try { mt.localStorage.l.load(document.location.hostname), mt.localStorage.l.removeAttribute(a), mt.localStorage.l.save(document.location.hostname) } catch (e) { } }; mt.sessionStorage = {}; mt.sessionStorage.set = function (a, e) { try { window.sessionStorage && window.sessionStorage.setItem(a, e) } catch (b) { } };
    mt.sessionStorage.get = function (a) { try { return window.sessionStorage ? window.sessionStorage.getItem(a) : w } catch (e) { return w } }; mt.sessionStorage.remove = function (a) { try { window.sessionStorage && window.sessionStorage.removeItem(a) } catch (e) { } }; mt.cb = {}; mt.cb.log = function (a, e) { var b = new Image, d = "mini_tangram_log_" + Math.floor(2147483648 * Math.random()).toString(36); window[d] = b; b.onload = function () { b.onload = w; b = window[d] = w; e && e(a) }; b.src = a }; mt.Ha = {};
    mt.Ha.Rb = function () { var a = ""; if (navigator.plugins && navigator.mimeTypes.length) { var e = navigator.plugins["Shockwave Flash"]; e && e.description && (a = e.description.replace(/^.*\s+(\S+)\s+\S+$/, "$1")) } else if (window.ActiveXObject) try { if (e = new ActiveXObject("ShockwaveFlash.ShockwaveFlash")) (a = e.GetVariable("$version")) && (a = a.replace(/^.*\s+(\d+),(\d+).*$/, "$1.$2")) } catch (b) { } return a };
    mt.Ha.Cc = function (a, e, b, d, f) { return '<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" id="' + a + '" width="' + b + '" height="' + d + '"><param name="movie" value="' + e + '" /><param name="flashvars" value="' + (f || "") + '" /><param name="allowscriptaccess" value="always" /><embed type="application/x-shockwave-flash" name="' + a + '" width="' + b + '" height="' + d + '" src="' + e + '" flashvars="' + (f || "") + '" allowscriptaccess="always" /></object>' };
    (function () { function a() { for (var a = x, b = document.getElementsByTagName("script"), d = b.length, d = 100 < d ? 100 : d, f = 0; f < d; f++) { var l = b[f].src; if (l && 0 === l.indexOf("https://hm.baidu.com/h")) { a = v; break } } return a } return h.Bb = a })(); var A = h.Bb;
    h.m = {
        Zb: "http://tongji.baidu.com/hm-web/welcome/ico", Fa: "hm.baidu.com/hm.gif", mb: /^(tongji|hmcdn).baidu.com$/, fb: "tongji.baidu.com", Wb: "hmmd", Xb: "hmpl", yc: "utm_medium", Vb: "hmkw", Ac: "utm_term", Tb: "hmci", xc: "utm_content", Yb: "hmsr", zc: "utm_source", Ub: "hmcu", wc: "utm_campaign", M: 0, H: Math.round(+new Date / 1E3), protocol: "https:" === document.location.protocol ? "https:" : "http:", ha: A() || "https:" === document.location.protocol ? "https:" : "http:", Ec: 0, ub: 6E5, fc: 6E5, nc: 5E3, vb: 5, P: 1024, tb: 1, N: 2147483647, eb: "hca kb cc cf ci ck cl cm cp cu cw ds vl ep et fl ja ln lo lt rnd si su v cv lv api sn p ct u tt".split(" "),
        W: v, Na: ["a", "input", "button"], ob: { id: "data-hm-id", ra: "data-hm-class", Ka: "data-hm-xpath", content: "data-hm-content", Ia: "data-hm-tag", link: "data-hm-link" }, Ma: "data-hm-enabled", La: "data-hm-disabled", jc: "https://hmcdn.baidu.com/static/tongji/plugins/", Ya: ["UrlChangeTracker"]
    }; (function () { var a = { D: {}, d: function (a, b) { this.D[a] = this.D[a] || []; this.D[a].push(b) }, I: function (a, b) { this.D[a] = this.D[a] || []; for (var d = this.D[a].length, f = 0; f < d; f++)this.D[a][f](b) } }; return h.r = a })();
    (function () { function a(a, d) { var f = document.createElement("script"); f.charset = "utf-8"; e.e(d, "Function") && (f.readyState ? f.onreadystatechange = function () { if ("loaded" === f.readyState || "complete" === f.readyState) f.onreadystatechange = w, d() } : f.onload = function () { d() }); f.src = a; var l = document.getElementsByTagName("script")[0]; l.parentNode.insertBefore(f, l) } var e = mt.lang; return h.load = a })();
    (function () { function a() { var a = ""; if (h.c.b.nv) { a = encodeURIComponent(document.referrer); try { window.sessionStorage ? b.set("Hm_from_" + c.id, a) : e.set("Hm_from_" + c.id, a, 864E5) } catch (f) { } } else try { a = (window.sessionStorage ? b.get("Hm_from_" + c.id) : e.get("Hm_from_" + c.id)) || "" } catch (l) { } return a } var e = mt.localStorage, b = mt.sessionStorage; return h.Cb = a })();
    (function () { var a = h.m, e = { init: function () { if ("" !== c.icon) { var b = c.icon.split("|"), d = a.Zb + "?s=" + c.id, e = "https://hmcdn.baidu.com/static" + b[0] + ".gif"; document.write("swf" === b[1] || "gif" === b[1] ? '<a href="' + d + '" target="_blank"><img border="0" src="' + e + '" width="' + b[2] + '" height="' + b[3] + '"></a>' : '<a href="' + d + '" target="_blank">' + b[0] + "</a>") } } }; h.r.d("pv-b", e.init); return e })();
    (function () {
        var a = mt.cookie, e = mt.localStorage, b = mt.sessionStorage, d = {
            getData: function (d) { try { return a.get(d) || b.get(d) || e.get(d) } catch (l) { } }, setData: function (f, l, k) { try { a.set(f, l, { domain: d.T(), path: d.ca(), S: k }), k ? e.set(f, l, k) : b.set(f, l) } catch (m) { } }, lc: function (f) { try { a.set(f, "", { domain: d.T(), path: d.ca(), S: -1 }), b.remove(f), e.remove(f) } catch (l) { } }, X: function (a, d) { a = "." + a.replace(/:\d+/, ""); d = "." + d.replace(/:\d+/, ""); var b = a.indexOf(d); return -1 < b && b + d.length === a.length }, ga: function (a, d) {
                a = a.replace(/^https?:\/\//,
                    ""); return 0 === a.indexOf(d)
            }, T: function () { for (var a = document.location.hostname, b = 0, e = c.dm.length; b < e; b++)if (d.X(a, c.dm[b])) return c.dm[b].replace(/(:\d+)?[/?#].*/, ""); return a }, ca: function () { for (var a = 0, b = c.dm.length; a < b; a++) { var e = c.dm[a]; if (-1 < e.indexOf("/") && d.ga(document.location.href, e)) return e.replace(/^[^/]+(\/.*)/, "$1") + "/" } return "/" }
        }; return h.sa = d
    })();
    (function () {
        var a = mt.lang, e = mt.s, b = h.sa, d = { pageview: {}, session: {}, autoEventTracking: {}, customEvent: {}, user: {} }, f = { user: 1, session: 2, pageview: 3, autoEventTracking: 3, customEvent: 3, others: 3 }, l = ["session", "user"], k = "Hm_up_" + c.id, m = {
            init: function () { m.bc() }, bc: function () { try { var f = e.parse(decodeURIComponent(b.getData(k))); a.e(f, "Object") && (d.user = f) } catch (m) { } }, A: function (a) { var b = {}; d[a] !== s && (b = d[a]); a = this.xa(); for (var e in b) b.hasOwnProperty(e) && (a[e] = b[e]); return a }, xa: function () {
                for (var a = {}, b, e = l.length -
                    1; 0 <= e; e--) { b = d[l[e]]; for (var f in b) b.hasOwnProperty(f) && (a[f] = b[f]) } return a
            }, setProperty: function (b, f, k) { var q = d[b]; if (a.e(q, "Object") && a.e(f, "Object")) { for (var l in f) if (f.hasOwnProperty(l)) { var g = a.g(String(l)); if (k || !((/^_/.test(g) || /_$/.test(g)) && "_iden" !== g)) { var n = f[l]; if (n == w) delete q[g]; else { if (a.e(n, "Object") || a.e(n, "Array")) n = e.stringify(n); n = a.g(String(n)); m.dc(b, g, n) && (q[g] = { value: n, scope: m.Sa(b) }) } } } "user" === b && m.Da() } }, z: function (b) {
            b !== s && ("userId" === b && a.e(d.user, "Object") ? (delete d.user.uid_,
                m.Da()) : "user" === b && a.e(d.user, "Object") ? (b = d.user.uid_, d.user = b === s ? {} : { uid_: b }, m.Da()) : d[b] !== s && (d[b] = {}))
            }, Da: function () { try { b.setData(k, encodeURIComponent(e.stringify(d.user)), c.age) } catch (a) { } }, dc: function (a, b, e) { var f = v, k = d[a]; if (256 < encodeURIComponent(String(b)).length || 256 < encodeURIComponent(String(e)).length) f = x; else { var g = k[b]; k[b] = { value: e, scope: m.Sa(a) }; a = m.O(m.A(a)); 2048 < encodeURIComponent(a).length && (g !== s ? k[b] = g : delete k[b], f = x) } return f }, O: function (a) {
                var d = [], b, e; for (e in a) a.hasOwnProperty(e) &&
                    (b = [e, a[e].value], (1 === a[e].scope || 2 === a[e].scope) && b.push(a[e].scope), d.push(b.join("*"))); return d.join("!")
            }, Sa: function (a) { a = f[a]; return a !== s ? a : f.others }
        }; return h.R = m
    })();
    (function () {
        var a = mt.f, e = mt.lang, b = mt.s, d = h.r, f = h.R, l = f.O; if (e.isArray(c.cptrk) && 0 < c.cptrk.length) {
            var k = {
                Xa: {}, la: {}, init: function () { for (var a, d = 0; d < c.cptrk.length; d++)try { if (a = b.parse(decodeURIComponent(String(c.cptrk[d]))), a.a !== s && e.e(a.a, "Object")) { var f = a.a, l; for (l in f) f.hasOwnProperty(l) && (k.la[l] = String(f[l])) } } catch (q) { } }, Wa: function () { var d, b, e; for (e in k.la) if (k.la.hasOwnProperty(e) && k.Xa[e] === s && (d = k.la[e], d = a.Pa(d))) b = b === s ? {} : b, b[e] = a.ua(d, x), k.Xa[e] = v; return b }, ya: function () {
                    var a =
                        k.Wa(); a && k.qc(a)
                }, ac: function () { "MutationObserver" in window ? (new MutationObserver(k.ya)).observe(document.body, { childList: v, subtree: v }) : window.setInterval(k.ya, 15E3) }, qc: function (a) { if (e.e(a, "Object")) { f.setProperty("pageview", a); a = h.c.b.p; var d = h.c.b.ep; h.c.b.et = 9; h.c.b.ep = ""; h.c.b.p = l(f.A("pageview")); h.c.h(); h.c.b.p = a; h.c.b.ep = d; f.z("pageview") } }
            }; k.init(); d.d("pv-b", function () { var a = k.Wa(); a && f.setProperty("pageview", a) }); k.ac(); a.Ga(k.ya)
        }
    })();
    (function () {
        var a = mt.lang, e = mt.f, b = {
            Q: function (a, f) { return function (l) { var k = l.target || l.srcElement; if (k) { var m = k.getAttribute(a.$); l = l.clientX + ":" + l.clientY; if (m && m === l) k.removeAttribute(a.$); else if (f && 0 < f.length && (k = e.Nb(k)) && k.length) if (m = k.length, l = k[k.length - 1], 1E4 > m * l.split(">").length) for (l = 0; l < m; l++)b.bb(a, k[l]); else b.bb(a, l) } } }, bb: function (d, b) { for (var e = {}, k = String(b).split(">").length, m = 0; m < k; m++)e[b] = "", b = b.substring(0, b.lastIndexOf(">")); d && (a.e(d, "Object") && d.qa) && d.qa(e) }, Za: function (a,
                b) { return function (e) { (e.target || e.srcElement).setAttribute(a.$, e.clientX + ":" + e.clientY); a && a.w && (b ? a.w(b) : a.w("#" + encodeURIComponent(this.id), e.type)) } }
        }; return h.aa = b
    })();
    (function () {
        var a = mt.f, e = mt.event, b = h.aa, d = {
            $: "HM_fix", pa: function () { e.d(document, "click", b.Q(d, c.etrk)); for (var f = c.etrk.length, l = 0; l < f; l++) { var k = c.etrk[l], m = decodeURIComponent(String(k.id)); -1 === m.indexOf(">") && (0 === m.indexOf("#") && (m = m.substring(1)), (m = a.ba(decodeURIComponent(m))) && e.d(m, k.eventType, b.Za(d))) } }, qa: function (a) { if (c.etrk && c.etrk.length) for (var b = c.etrk.length, e = 0; e < b; e++) { var m = decodeURIComponent(String(c.etrk[e].id)); a.hasOwnProperty(m) && d.w(m) } }, w: function (a, b) {
                h.c.b.et = 1; h.c.b.ep =
                    "{id:" + a + ",eventType:" + (b || "click") + "}"; h.c.h()
            }
        }; h.r.d("pv-b", d.pa); return d
    })();
    (function () {
        var a = mt.f, e = mt.s, b = mt.event, d = mt.lang, f = h.aa, l = h.R, k = l.O, m = {
            $: "HM_ce", pa: function () { if (c.cetrk && c.cetrk.length) { b.d(document, "click", f.Q(m, c.cetrk)); for (var d = 0, k = c.cetrk.length; d < k; d++) { var l; try { l = e.parse(decodeURIComponent(String(c.cetrk[d]))) } catch (q) { l = {} } var t = l.p || ""; -1 === t.indexOf(">") && (0 === t.indexOf("#") && (t = t.substring(1)), (t = a.ba(t)) && b.d(t, "click", f.Za(m, l))) } } }, qa: function (a) {
                if (c.cetrk && c.cetrk.length) for (var b = 0, d = c.cetrk.length; b < d; b++) {
                    var f; try { f = e.parse(decodeURIComponent(String(c.cetrk[b]))) } catch (k) {
                        f =
                        {}
                    } var g = m.Gb(f.p, a); g && m.w(f, g)
                }
            }, Gb: function (a, b) { a = String(a); if (0 < a.indexOf("*")) { var d = RegExp("^" + a.replace(/\[/g, "\\[").replace(/\]/g, "\\]").replace(/\*/, "\\d+") + "$"), e; for (e in b) if (b.hasOwnProperty(e) && d.test(e)) return e; return w } return b.hasOwnProperty(a) ? a : w }, w: function (b, e) {
                h.c.b.et = 7; var f = b && b.k || "", f = d.g(f), q = {}; if (b && b.a && d.e(b.a, "Object")) { var t = b.a, g; for (g in t) if (t.hasOwnProperty(g)) { var n = m.Ob(t[g] || "", e), n = n ? a.ua(n, x) : ""; q[g] = n } } q._iden = f; l.setProperty("customEvent", q); h.c.b.ep =
                    ""; h.c.b.p = k(l.A("customEvent")); h.c.h(); h.c.b.p = ""; l.z("customEvent")
            }, Ob: function (b, d) { b = String(b); d = String(d); if (0 < b.indexOf("*")) { var e = /.*\[(\d+)\]$/.exec(d); b = b.replace("*", e ? e[1] : "1") } return a.Pa(b) }
        }; h.r.d("pv-b", m.pa); return m
    })();
    (function () {
        var a = mt.f, e = mt.lang, b = mt.event, d = mt.i, f = h.m, l = h.r, k = [], m = {
            gb: function () { c.ctrk && (b.d(document, "mouseup", m.rb()), b.d(window, "unload", function () { m.ia() }), setInterval(function () { m.ia() }, f.ub)) }, rb: function () {
                return function (a) {
                    a = m.Eb(a); if ("" !== a) {
                        var b = (f.ha + "//" + f.Fa + "?" + h.c.ab().replace(/ep=[^&]*/, "ep=" + encodeURIComponent(a))).length; b + (f.N + "").length > f.P || (b + encodeURIComponent(k.join("!") + (k.length ? "!" : "")).length + (f.N + "").length > f.P && m.ia(), k.push(a), (k.length >= f.vb || /\*a\*/.test(a)) &&
                            m.ia())
                    }
                }
            }, Eb: function (b) {
                var k = b.target || b.srcElement; if (0 === f.tb) { var l = (k.tagName || "").toLowerCase(); if ("embed" == l || "object" == l) return "" } var t; d.Aa ? (t = Math.max(document.documentElement.scrollTop, document.body.scrollTop), l = Math.max(document.documentElement.scrollLeft, document.body.scrollLeft), l = b.clientX + l, t = b.clientY + t) : (l = b.pageX, t = b.pageY); b = m.Kb(b, k, l, t); var g = window.innerWidth || document.documentElement.clientWidth || document.body.offsetWidth; switch (c.align) { case 1: l -= g / 2; break; case 2: l -= g }g =
                    []; g.push(l); g.push(t); g.push(b.gc); g.push(b.hc); g.push(b.kc); g.push(e.g(b.ic)); g.push(b.Bc); g.push(b.Sb); (k = "a" === (k.tagName || "").toLowerCase() ? k : a.Db(k)) ? (g.push("a"), g.push(e.g(encodeURIComponent(k.href)))) : g.push("b"); return g.join("*")
            }, Kb: function (b, f, k, l) {
                b = a.Ra(f); var g = 0, n = 0, z = 0, y = 0; if (f && (g = f.offsetWidth || f.clientWidth, n = f.offsetHeight || f.clientHeight, y = a.Lb(f), z = y.left, y = y.top, e.e(f.getBBox, "Function") && (n = f.getBBox(), g = n.width, n = n.height), "html" === (f.tagName || "").toLowerCase())) g = Math.max(g,
                    f.clientWidth), n = Math.max(n, f.clientHeight); return { gc: Math.round(100 * ((k - z) / g)), hc: Math.round(100 * ((l - y) / n)), kc: d.orientation, ic: b, Bc: g, Sb: n }
            }, ia: function () { 0 !== k.length && (h.c.b.et = 2, h.c.b.ep = k.join("!"), h.c.h(), k = []) }
        }, p = { jb: function () { c.ctrk && setInterval(p.oc, f.nc) }, oc: function () { var a = d.V() + d.J(); 0 < a - h.c.b.vl && (h.c.b.vl = a) } }; l.d("pv-b", m.gb); l.d("pv-b", p.jb); return m
    })();
    (function () {
        var a = mt.lang, e = mt.f, b = mt.event, d = mt.i, f = h.m, l = h.r, k = h.R, m = k.O, p = +new Date, r = [], u = {
            Q: function () {
                return function (b) {
                    if (h.c && h.c.W && c.aet && c.aet.length) {
                        var d = b.target || b.srcElement; if (d) {
                            var g = h.c.Na, n = e.getAttribute(d, f.Ma) != w ? v : x; if (e.getAttribute(d, f.La) == w) if (n) u.na(u.va(d, b)); else {
                                var k = e.da(d); if (a.K(g, "*") || a.K(g, k)) u.na(u.va(d, b)); else for (; d.parentNode != w;) {
                                    var n = d.parentNode, k = e.da(n), y = "a" === k && a.K(g, "a") ? v : x, k = "button" === k && a.K(g, "button") ? v : x, G = e.getAttribute(n, f.Ma) != w ? v :
                                        x; if (e.getAttribute(n, f.La) == w && (y || k || G)) { u.na(u.va(n, b)); break } d = d.parentNode
                                }
                            }
                        }
                    }
                }
            }, va: function (b, k) {
                var g = {}, n = f.ob; g.id = e.getAttribute(b, n.id) || e.getAttribute(b, "id") || ""; g.ra = e.getAttribute(b, n.ra) || e.getAttribute(b, "class") || ""; g.Ka = e.getAttribute(b, n.Ka) || e.Ra(b); g.content = e.getAttribute(b, n.content) || e.ua(b, v); g.Ia = e.getAttribute(b, n.Ia) || e.da(b); g.link = e.getAttribute(b, n.link) || e.getAttribute(b, "href") || ""; g.type = k.type || "click"; n = a.Ba(b.offsetTop) ? b.offsetTop : 0; "click" === k.type ? n = d.Aa ? k.clientY +
                    Math.max(document.documentElement.scrollTop, document.body.scrollTop) : k.pageY : "touchend" === k.type && (k.Ca && a.e(k.Ca.changedTouches, "Array") && k.Ca.changedTouches.length) && (n = k.Ca.changedTouches[0].pageY); g.vc = n; return g
            }, na: function (b) { var d = a.g; b = [+new Date - (h.c.F !== s ? h.c.F : p), d(b.id), d(b.ra), d(b.Ia), d(b.Ka), d(b.link), d(b.content), b.type, b.vc].join("*"); u.oa(b); a.e(this.Z(), "Function") && this.Z()() }, oa: function (a) { a.length > f.P || (encodeURIComponent(r.join("!") + a).length > f.P && (u.w(r.join("!")), r = []), r.push(a)) },
            w: function (a) { h.c.b.et = 5; h.c.b.ep = a; h.c.b.p = m(k.A("autoEventTracking")); h.c.h(); h.c.b.p = "" }, Z: function () { return function () { r && r.length && (u.w(r.join("!")), r = []) } }
        }; a.L(c.aet) && "" !== c.aet && l.d("pv-b", function () { b.d(document, "click", u.Q()); "ontouchend" in document && b.d(window, "touchend", u.Q()); b.d(window, "unload", u.Z()) }); return u
    })();
    (function () {
        var a = mt.event, e = mt.i, b = h.m, d = h.r, f = +new Date, l = [], k = w, m = {
            yb: function () { return function () { h.c && (h.c.W && c.aet && c.aet.length) && (window.clearTimeout(k), k = window.setTimeout(function () { m.ib(e.V() + e.J()) }, 150)) } }, ib: function (a) { m.oa([+new Date - (h.c.F !== s ? h.c.F : f), a].join("*")) }, oa: function (a) { if (encodeURIComponent(l.join("!") + a).length > b.P || 3 < l.length) m.w(l.join("!")), l = []; l.push(a) }, w: function (a) { h.c.b.et = 6; h.c.b.vh = e.J(); h.c.b.ep = a; h.c.h() }, Z: function () {
                return function () {
                l && l.length && (m.w(l.join("!")),
                    l = [])
                }
            }
        }; mt.lang.L(c.aet) && "" !== c.aet && d.d("pv-b", function () { a.d(window, "scroll", m.yb()); a.d(window, "unload", m.Z()) }); return m
    })();
    (function () {
        var a = mt.f, e = h.m, b = h.load, d = h.Cb; h.r.d("pv-b", function () {
            var f = e.protocol + "//crs.baidu.com/"; c.rec && a.Ga(function () {
                for (var l = 0, k = c.rp.length; l < k; l++) {
                    var m = c.rp[l][0], p = c.rp[l][1], r = a.ba("hm_t_" + m); if (p && !(2 == p && !r || r && "" !== r.innerHTML)) r = "", r = Math.round(Math.random() * e.N), r = 4 == p ? f + "hl.js?" + ["siteId=" + c.id, "planId=" + m, "rnd=" + r].join("&") : f + "t.js?" + ["siteId=" + c.id, "planId=" + m, "from=" + d(), "referer=" + encodeURIComponent(document.referrer), "title=" + encodeURIComponent(document.title), "rnd=" +
                        r].join("&"), b(r)
                }
            })
        })
    })();
    (function () {
        function a() { return function () { h.c.b.nv = 0; h.c.b.st = 4; h.c.b.et = 3; h.c.b.ep = h.ta.Mb() + "," + h.ta.Hb(); h.c.h() } } function e() { clearTimeout(y); var a; n && (a = "visible" == document[n]); z && (a = !document[z]); m = "undefined" == typeof a ? v : a; if ((!k || !p) && m && r) g = v, q = +new Date; else if (k && p && (!m || !r)) g = x, t += +new Date - q; k = m; p = r; y = setTimeout(e, 100) } function b(a) {
            var b = document, n = ""; if (a in b) n = a; else for (var d = ["webkit", "ms", "moz", "o"], e = 0; e < d.length; e++) {
                var y = d[e] + a.charAt(0).toUpperCase() + a.slice(1); if (y in b) {
                    n =
                    y; break
                }
            } return n
        } function d(a) { if (!("focus" == a.type || "blur" == a.type) || !(a.target && a.target != window)) r = "focus" == a.type || "focusin" == a.type ? v : x, e() } var f = mt.event, l = h.r, k = v, m = v, p = v, r = v, u = +new Date, q = u, t = 0, g = v, n = b("visibilityState"), z = b("hidden"), y; e(); (function () {
            var a = n.replace(/[vV]isibilityState/, "visibilitychange"); f.d(document, a, e); f.d(window, "pageshow", e); f.d(window, "pagehide", e); "object" == typeof document.onfocusin ? (f.d(document, "focusin", d), f.d(document, "focusout", d)) : (f.d(window, "focus", d),
                f.d(window, "blur", d))
        })(); h.ta = { Mb: function () { return +new Date - u }, Hb: function () { return g ? +new Date - q + t : t } }; l.d("pv-b", function () { f.d(window, "unload", a()) }); l.d("duration-send", a()); l.d("duration-done", function () { q = u = +new Date; t = 0 }); return h.ta
    })();
    (function () { var a = mt.lang, e = h.m, b = h.load, d = { $b: function (d) { if ((window._dxt === s || a.e(window._dxt, "Array")) && "undefined" !== typeof h.c) { var l = h.c.T(); b([e.protocol, "//datax.baidu.com/x.js?si=", c.id, "&dm=", encodeURIComponent(l)].join(""), d) } }, uc: function (b) { if (a.e(b, "String") || a.e(b, "Number")) window._dxt = window._dxt || [], window._dxt.push(["_setUserId", b]) } }; return h.wb = d })();
    (function () {
        function a(a, b, d, e) { if (!(a === s || b === s || e === s)) { if ("" === a) return [b, d, e].join("*"); a = String(a).split("!"); for (var f, k = x, g = 0; g < a.length; g++)if (f = a[g].split("*"), String(b) === f[0]) { f[1] = d; f[2] = e; a[g] = f.join("*"); k = v; break } k || a.push([b, d, e].join("*")); return a.join("!") } } function e(a) { for (var b in a) if ({}.hasOwnProperty.call(a, b)) { var y = a[b]; d.e(y, "Object") || d.e(y, "Array") ? e(y) : a[b] = String(y) } } var b = mt.url, d = mt.lang, f = mt.s, l = mt.i, k = h.m, m = h.r, p = h.wb, r = h.load, u = h.sa, q = h.R, t = q.O, g = {
            Y: [], ka: 0, Va: x,
            C: { Ja: "", page: "" }, init: function () { g.j = 0; q.init(); m.d("pv-b", function () { g.xb(); g.zb() }); m.d("pv-d", function () { g.Ab(); g.C.page = "" }); m.d("stag-b", function () { h.c.b.api = g.j || g.ka ? g.j + "_" + g.ka : ""; h.c.b.ct = [decodeURIComponent(u.getData("Hm_ct_" + c.id) || ""), g.C.Ja, g.C.page].join("!") }); m.d("stag-d", function () { h.c.b.api = 0; g.j = 0; g.ka = 0 }) }, xb: function () {
                var a = window._hmt || []; if (!a || d.e(a, "Array")) window._hmt = {
                    id: c.id, cmd: {}, push: function () {
                        for (var a = window._hmt, b = 0; b < arguments.length; b++) {
                            var n = arguments[b];
                            d.e(n, "Array") && (a.cmd[a.id].push(n), "_setAccount" === n[0] && (1 < n.length && /^[0-9a-f]{32}$/.test(n[1])) && (n = n[1], a.id = n, a.cmd[n] = a.cmd[n] || []))
                        }
                    }
                }, window._hmt.cmd[c.id] = [], window._hmt.push.apply(window._hmt, a)
            }, zb: function () { var a = window._hmt; if (a && a.cmd && a.cmd[c.id]) for (var b = a.cmd[c.id], d = /^_track(Event|MobConv|Order|RTEvent)$/, e = 0, f = b.length; e < f; e++) { var k = b[e]; d.test(k[0]) ? g.Y.push(k) : g.Ea(k) } a.cmd[c.id] = { push: g.Ea } }, Ab: function () {
                if (0 < g.Y.length) for (var a = 0, b = g.Y.length; a < b; a++)g.Ea(g.Y[a]); g.Y =
                    w
            }, Ea: function (a) { var b = a[0]; if (g.hasOwnProperty(b) && d.e(g[b], "Function")) g[b](a) }, _setAccount: function (a) { 1 < a.length && /^[0-9a-f]{32}$/.test(a[1]) && (g.j |= 1) }, _setAutoPageview: function (a) { if (1 < a.length && (a = a[1], x === a || v === a)) g.j |= 2, h.c.Ta = a }, _trackPageview: function (a) {
                if (1 < a.length && a[1].charAt && "/" === a[1].charAt(0)) {
                g.j |= 4; h.c.b.sn = h.c.Qa(); h.c.b.et = 0; h.c.b.ep = ""; h.c.b.vl = l.V() + l.J(); h.c.b.kb = 0; h.c.za ? (h.c.b.nv = 0, h.c.b.st = 4) : h.c.za = v; var b = h.c.b.u, d = h.c.b.su; h.c.b.u = k.protocol + "//" + document.location.host +
                    a[1]; g.Va || (h.c.b.su = document.location.href); h.c.b.p = t(q.A("pageview")); h.c.h(); h.c.b.u = b; h.c.b.su = d; h.c.b.p = ""; h.c.F = +new Date; q.z("pageview")
                }
            }, _trackEvent: function (a) { 2 < a.length && (g.j |= 8, h.c.b.nv = 0, h.c.b.st = 4, h.c.b.et = 4, h.c.b.ep = d.g(a[1]) + "*" + d.g(a[2]) + (a[3] ? "*" + d.g(a[3]) : "") + (a[4] ? "*" + d.g(a[4]) : ""), h.c.b.p = t(q.xa()), h.c.h(), h.c.b.p = "") }, _setCustomVar: function (a) {
                if (!(4 > a.length)) {
                    var b = a[1], e = a[4] || 3; if (0 < b && 6 > b && 0 < e && 4 > e) {
                    g.ka++; for (var f = (h.c.b.cv || "*").split("!"), k = f.length; k < b - 1; k++)f.push("*");
                        f[b - 1] = e + "*" + d.g(a[2]) + "*" + d.g(a[3]); h.c.b.cv = f.join("!"); a = h.c.b.cv.replace(/[^1](\*[^!]*){2}/g, "*").replace(/((^|!)\*)+$/g, ""); "" !== a ? u.setData("Hm_cv_" + c.id, encodeURIComponent(a), c.age) : u.lc("Hm_cv_" + c.id)
                    }
                }
            }, _setUserTag: function (b) { if (!(3 > b.length)) { var e = d.g(b[1]); b = d.g(b[2]); if (e !== s && b !== s) { var f = decodeURIComponent(u.getData("Hm_ct_" + c.id) || ""), f = a(f, e, 1, b); u.setData("Hm_ct_" + c.id, encodeURIComponent(f), c.age) } } }, _setVisitTag: function (b) {
                if (!(3 > b.length)) {
                    var e = d.g(b[1]); b = d.g(b[2]); if (e !==
                        s && b !== s) { var f = g.C.Ja, f = a(f, e, 2, b); g.C.Ja = f }
                }
            }, _setPageTag: function (b) { if (!(3 > b.length)) { var e = d.g(b[1]); b = d.g(b[2]); if (e !== s && b !== s) { var f = g.C.page, f = a(f, e, 3, b); g.C.page = f } } }, _setReferrerOverride: function (a) { 1 < a.length && (h.c.b.su = a[1].charAt && "/" === a[1].charAt(0) ? k.protocol + "//" + window.location.host + a[1] : a[1], g.Va = v) }, _trackOrder: function (a) { a = a[1]; d.e(a, "Object") && (e(a), g.j |= 16, h.c.b.nv = 0, h.c.b.st = 4, h.c.b.et = 94, h.c.b.ep = f.stringify(a), h.c.b.p = t(q.xa()), h.c.h(), h.c.b.p = "") }, _trackMobConv: function (a) {
                if (a =
                    { webim: 1, tel: 2, map: 3, sms: 4, callback: 5, share: 6 }[a[1]]) g.j |= 32, h.c.b.et = 93, h.c.b.ep = a, h.c.h()
            }, _setDataxId: function (a) { a = a[1]; p.$b(); p.uc(a) }, _setUserId: function (a) { a = a[1]; if (a !== s && (d.L(a) || d.Ba(a))) { var b = q.A("user").uid_; if (!(b && b.value === d.g(String(a)))) { var b = h.c.b.p, e = h.c.b.ep; h.c.b.et = 8; h.c.b.ep = ""; h.c.b.p = "uid_*" + d.g(String(a)); h.c.h(); var f = {}; f.uid_ = a; q.setProperty("user", f, v); h.c.b.p = b; h.c.b.ep = e } } }, _clearUserId: function (a) { 1 < a.length && v === a[1] && q.z("userId") }, _setUserProperty: function (a) {
                a =
                a[1]; d.e(a, "Object") && q.setProperty("user", a)
            }, _clearUserProperty: function (a) { 1 < a.length && v === a[1] && q.z("user") }, _setSessionProperty: function (a) { a = a[1]; d.e(a, "Object") && q.setProperty("session", a) }, _clearSessionProperty: function (a) { 1 < a.length && v === a[1] && q.z("session") }, _setPageviewProperty: function (a) { a = a[1]; d.e(a, "Object") && q.setProperty("pageview", a) }, _clearPageviewProperty: function (a) { 1 < a.length && v === a[1] && q.z("pageview") }, _setAutoEventTrackingProperty: function (a) {
                a = a[1]; d.e(a, "Object") && q.setProperty("autoEventTracking",
                    a)
            }, _clearAutoEventTrackingProperty: function (a) { 1 < a.length && v === a[1] && q.z("autoEventTracking") }, _setAutoTracking: function (a) { if (1 < a.length && (a = a[1], x === a || v === a)) h.c.Ua = a }, _setAutoEventTracking: function (a) { if (1 < a.length && (a = a[1], x === a || v === a)) h.c.W = a }, _trackPageDuration: function (a) { 1 < a.length ? (a = a[1], 2 === String(a).split(",").length && (h.c.b.et = 3, h.c.b.ep = a, h.c.h())) : m.I("duration-send"); m.I("duration-done") }, _require: function (a) { 1 < a.length && (a = a[1], k.mb.test(b.U(a)) && r(a)) }, _providePlugin: function (a) {
                if (1 <
                    a.length) { var b = window._hmt, e = a[1]; a = a[2]; if (d.K(k.Ya, e) && d.e(a, "Function") && (b.plugins = b.plugins || {}, b.G = b.G || {}, b.plugins[e] = a, b.B = b.B || [], a = b.B.slice(), e && a.length && a[0][1] === e)) for (var f = 0, g = a.length; f < g; f++) { var l = a[f][2] || {}; if (b.plugins[e] && !b.G[e]) b.G[e] = new b.plugins[e](l), b.B.shift(); else break } }
            }, _requirePlugin: function (a) {
                if (1 < a.length) {
                    var b = window._hmt, e = a[1], f = a[2] || {}; if (d.K(k.Ya, e)) if (b.plugins = b.plugins || {}, b.G = b.G || {}, b.plugins[e] && !b.G[e]) b.G[e] = new b.plugins[e](f); else {
                    b.B = b.B ||
                        []; for (var f = 0, l = b.B.length; f < l; f++)if (b.B[f][1] === e) return; b.B.push(a); g._require([w, k.jc + e + ".js"])
                    }
                }
            }, _trackCustomEvent: function (a) { if (1 < a.length) { var b = a[1]; a = a[2]; d.e(a, "Object") || (a = {}); a._iden = b; q.setProperty("customEvent", a); h.c.b.et = 7; h.c.b.ep = ""; h.c.b.p = t(q.A("customEvent")); h.c.h(); h.c.b.p = ""; q.z("customEvent") } }
        }; g.init(); h.nb = g; return h.nb
    })();
    (function () { var a = h.r; c.spa !== s && "1" === String(c.spa) && (window._hmt = window._hmt || [], window._hmt.push(["_requirePlugin", "UrlChangeTracker"]), a.d("pv-b", function () { "" !== window.location.hash && (h.c.b.u = window.location.href) })) })();
    (function () {
        function a() { "undefined" === typeof window["_bdhm_loaded_" + c.id] && (window["_bdhm_loaded_" + c.id] = v, this.b = {}, this.Ua = this.Ta = v, this.W = g.W, this.Na = f.L(c.aet) && 0 < c.aet.length ? c.aet.split(",") : "", this.za = x, this.init()) } var e = mt.url, b = mt.cb, d = mt.Ha, f = mt.lang, l = mt.cookie, k = mt.i, m = mt.sessionStorage, p = mt.s, r = mt.event, u = h.sa, q = h.R, t = q.O, g = h.m, n = h.load, z = h.r; a.prototype = {
            X: function (a, b) { a = "." + a.replace(/:\d+/, ""); b = "." + b.replace(/:\d+/, ""); var d = a.indexOf(b); return -1 < d && d + b.length === a.length }, ga: function (a,
                b) { a = a.replace(/^https?:\/\//, ""); return 0 === a.indexOf(b) }, ea: function (a) { for (var b = 0; b < c.dm.length; b++)if (-1 < c.dm[b].indexOf("/")) { if (this.ga(a, c.dm[b])) return v } else { var d = e.U(a); if (d && this.X(d, c.dm[b])) return v } return x }, T: function () { for (var a = document.location.hostname, b = 0, d = c.dm.length; b < d; b++)if (this.X(a, c.dm[b])) return c.dm[b].replace(/(:\d+)?[/?#].*/, ""); return a }, ca: function () {
                    for (var a = 0, b = c.dm.length; a < b; a++) {
                        var d = c.dm[a]; if (-1 < d.indexOf("/") && this.ga(document.location.href, d)) return d.replace(/^[^/]+(\/.*)/,
                            "$1") + "/"
                    } return "/"
                }, Pb: function () { if (!document.referrer) return g.H - g.M > c.vdur ? 1 : 4; var a = x; this.ea(document.referrer) && this.ea(document.location.href) ? a = v : (a = e.U(document.referrer), a = this.X(a || "", document.location.hostname)); return a ? g.H - g.M > c.vdur ? 1 : 4 : 3 }, sc: function () {
                    var a, b, d, e, f; g.M = u.getData("Hm_lpvt_" + c.id) || 0; 13 === g.M.length && (g.M = Math.round(g.M / 1E3)); b = this.Pb(); a = 4 !== b ? 1 : 0; if (d = u.getData("Hm_lvt_" + c.id)) {
                        e = d.split(","); for (f = e.length - 1; 0 <= f; f--)13 === e[f].length && (e[f] = "" + Math.round(e[f] /
                            1E3)); for (; 2592E3 < g.H - e[0];)e.shift(); f = 4 > e.length ? 2 : 3; for (1 === a && e.push(g.H); 4 < e.length;)e.shift(); d = e.join(","); e = e[e.length - 1]
                    } else d = g.H, e = "", f = 1; u.setData("Hm_lvt_" + c.id, d, c.age); u.setData("Hm_lpvt_" + c.id, g.H); d = l.ec(this.T(), this.ca()); if (0 === c.nv && this.ea(document.location.href) && ("" === document.referrer || this.ea(document.referrer))) a = 0, b = 4; this.b.nv = a; this.b.st = b; this.b.cc = d; this.b.lt = e; this.b.lv = f
                }, ab: function () {
                    for (var a = [], b = this.b.et, d = +new Date, e = 0, f = g.eb.length; e < f; e++) {
                        var k = g.eb[e],
                        l = this.b[k]; "undefined" !== typeof l && "" !== l && ("tt" !== k || "tt" === k && 0 === b) && (("ct" !== k || "ct" === k && 0 === b) && ("kb" !== k || "kb" === k && 3 === b)) && a.push(k + "=" + encodeURIComponent(l))
                    } switch (b) { case 0: this.b.rt && a.push("rt=" + encodeURIComponent(this.b.rt)); break; case 5: a.push("_lpt=" + this.F); a.push("_ct=" + d); break; case 6: a.push("_lpt=" + this.F); a.push("_ct=" + d); break; case 90: this.b.rt && a.push("rt=" + this.b.rt) }return a.join("&")
                }, tc: function () {
                    this.sc(); this.b.si = c.id; this.b.sn = this.Qa(); this.b.su = document.referrer;
                    this.b.ds = k.mc; this.b.cl = k.colorDepth + "-bit"; this.b.ln = String(k.language).toLowerCase(); this.b.ja = k.javaEnabled ? 1 : 0; this.b.ck = k.cookieEnabled ? 1 : 0; this.b.lo = "number" === typeof _bdhm_top ? 1 : 0; this.b.fl = d.Rb(); this.b.v = "1.2.65"; this.b.cv = decodeURIComponent(u.getData("Hm_cv_" + c.id) || ""); this.b.tt = document.title || ""; this.b.vl = k.V() + k.J(); var a = document.location.href; this.b.cm = e.o(a, g.Wb) || ""; this.b.cp = e.o(a, g.Xb) || e.o(a, g.yc) || ""; this.b.cw = e.o(a, g.Vb) || e.o(a, g.Ac) || ""; this.b.ci = e.o(a, g.Tb) || e.o(a, g.xc) ||
                        ""; this.b.cf = e.o(a, g.Yb) || e.o(a, g.zc) || ""; this.b.cu = e.o(a, g.Ub) || e.o(a, g.wc) || ""
                }, init: function () { try { this.tc(), 0 === this.b.nv ? this.rc() : this.Oa(), h.c = this, this.qb(), this.pb(), z.I("pv-b"), this.pc() } catch (a) { var d = []; d.push("si=" + c.id); d.push("n=" + encodeURIComponent(a.name)); d.push("m=" + encodeURIComponent(a.message)); d.push("r=" + encodeURIComponent(document.referrer)); b.log(g.ha + "//" + g.Fa + "?" + d.join("&")) } }, pc: function () {
                    function a() { z.I("pv-d") } this.Ta ? (this.za = v, this.b.et = 0, this.b.ep = "", this.b.p = t(q.A("pageview")),
                        this.b.vl = k.V() + k.J(), this.h(a), this.b.p = "") : a(); this.F = +new Date; q.z("pageview")
                }, h: function (a) { if (this.Ua) { var d = this; d.b.rnd = Math.round(Math.random() * g.N); z.I("stag-b"); var e = g.ha + "//" + g.Fa + "?" + d.ab(); z.I("stag-d"); d.lb(e); b.log(e, function (b) { d.$a(b); f.e(a, "Function") && a.call(d) }) } }, qb: function () {
                    var a = document.location.hash.substring(1), b = RegExp(c.id), d = e.U(document.referrer) === g.fb ? 1 : 0, f = e.o(a, "jn"), k = /^heatlink$|^select$|^pageclick$/.test(f); a && (b.test(a) && d && k) && (this.b.rnd = Math.round(Math.random() *
                        g.N), a = document.createElement("script"), a.setAttribute("type", "text/javascript"), a.setAttribute("charset", "utf-8"), a.setAttribute("src", g.protocol + "//" + c.js + f + ".js?" + this.b.rnd), f = document.getElementsByTagName("script")[0], f.parentNode.insertBefore(a, f))
                }, pb: function () {
                    if (window.postMessage && window.self !== window.parent) {
                        var a = this; r.d(window, "message", function (b) {
                            if (e.U(b.origin) === g.fb) {
                                b = b.data || {}; var d = b.jn || "", f = /^customevent$/.test(d); if (RegExp(c.id).test(b.sd || "") && f) a.b.rnd = Math.round(Math.random() *
                                    g.N), n(g.protocol + "//" + c.js + d + ".js?" + a.b.rnd)
                            }
                        }); window.parent.postMessage({ id: c.id, url: document.location.href, status: "__Messenger__hmLoaded" }, "*")
                    }
                }, lb: function (a) { var b; try { b = p.parse(m.get("Hm_unsent_" + c.id) || "[]") } catch (d) { b = [] } var e = this.b.u ? "" : "&u=" + encodeURIComponent(document.location.href); b.push(a.replace(/^https?:\/\//, "") + e); m.set("Hm_unsent_" + c.id, p.stringify(b)) }, $a: function (a) {
                    var b; try { b = p.parse(m.get("Hm_unsent_" + c.id) || "[]") } catch (d) { b = [] } if (b.length) {
                        a = a.replace(/^https?:\/\//, "");
                        for (var e = 0; e < b.length; e++)if (a.replace(/&u=[^&]*/, "") === b[e].replace(/&u=[^&]*/, "")) { b.splice(e, 1); break } b.length ? m.set("Hm_unsent_" + c.id, p.stringify(b)) : this.Oa()
                    }
                }, Oa: function () { m.remove("Hm_unsent_" + c.id) }, rc: function () { var a = this, d; try { d = p.parse(m.get("Hm_unsent_" + c.id) || "[]") } catch (e) { d = [] } if (d.length) for (var f = function (d) { b.log(g.ha + "//" + d, function (b) { a.$a(b) }) }, k = 0; k < d.length; k++)f(d[k]) }, Qa: function () { return Math.round(+new Date / 1E3) % 65535 }
        }; return new a
    })(); var B = h.m, C = h.load;
    if (c.apps) { var D = [B.protocol, "//ers.baidu.com/app/s.js?"]; D.push(c.apps); C(D.join("")) } (function () { var a = mt.event, e = mt.lang, b = h.m; if (c.kbtrk && "undefined" !== typeof h.c) { h.c.b.kb = e.Ba(h.c.b.kb) ? h.c.b.kb : 0; var d = function () { h.c.b.et = 85; h.c.b.ep = h.c.b.kb; h.c.h() }; a.d(document, "keyup", function () { h.c.b.kb++ }); a.d(window, "unload", function () { d() }); setInterval(d, b.fc) } })(); var E = h.m, F = h.load; c.pt && F([E.protocol, "//ada.baidu.com/phone-tracker/insert_bdtj?sid=", c.pt].join("")); var H = h.m, I = h.load;
    c.lxb && I([H.protocol, "//lxbjs.baidu.com/lxb.js?sid=", c.lxb].join("")); var J = h.load, K = h.m.protocol; if (c.qiao) { for (var L = [K + "//goutong.baidu.com/site/"], M = c.id, N = 5381, O = M.length, P = 0; P < O; P++)N = (33 * N + Number(M.charCodeAt(P))) % 4294967296; 2147483648 < N && (N -= 2147483648); L.push(N % 1E3 + "/"); L.push(c.id + "/b.js"); L.push("?siteId=" + c.qiao); J(L.join("")) }
    (function () {
        var a = mt.i, e = mt.lang, b = mt.event, d = mt.s; if ("undefined" !== typeof h.c && (c.med || (!a.Aa || 7 < a.Jb()) && c.cvcc)) {
            var f, l, k, m, p = function (a) { if (a.item) { for (var b = a.length, d = Array(b); b--;)d[b] = a[b]; return d } return [].slice.call(a) }, r = function (a, b) { for (var d in a) if (a.hasOwnProperty(d) && b.call(a, d, a[d]) === x) return x }, u = function (a, b) {
                var g = {}; g.n = f; g.t = "clk"; g.v = a; if (b) {
                    var l = b.getAttribute("href"), m = b.getAttribute("onclick") ? "" + b.getAttribute("onclick") : w, p = b.getAttribute("id") || ""; k.test(l) ? (g.sn =
                        "mediate", g.snv = l) : e.e(m, "String") && k.test(m) && (g.sn = "wrap", g.snv = m); g.id = p
                } h.c.b.et = 86; h.c.b.ep = d.stringify(g); h.c.h(); for (g = +new Date; 400 >= +new Date - g;);
            }; if (c.med) l = "/zoosnet", f = "swt", k = /swt|zixun|call|chat|zoos|business|talk|kefu|openkf|online|\/LR\/Chatpre\.aspx/i, m = {
                click: function () {
                    for (var a = [], b = p(document.getElementsByTagName("a")), b = [].concat.apply(b, p(document.getElementsByTagName("area"))), b = [].concat.apply(b, p(document.getElementsByTagName("img"))), d, e, f = 0, g = b.length; f < g; f++)d = b[f], e =
                        d.getAttribute("onclick"), d = d.getAttribute("href"), (k.test(e) || k.test(d)) && a.push(b[f]); return a
                }
            }; else if (c.cvcc) {
                l = "/other-comm"; f = "other"; k = c.cvcc.q || s; var q = c.cvcc.id || s; m = {
                    click: function () {
                        for (var a = [], b = p(document.getElementsByTagName("a")), b = [].concat.apply(b, p(document.getElementsByTagName("area"))), b = [].concat.apply(b, p(document.getElementsByTagName("img"))), d, e, f, g = 0, l = b.length; g < l; g++)d = b[g], k !== s ? (e = d.getAttribute("onclick"), f = d.getAttribute("href"), q ? (d = d.getAttribute("id"), (k.test(e) ||
                            k.test(f) || q.test(d)) && a.push(b[g])) : (k.test(e) || k.test(f)) && a.push(b[g])) : q !== s && (d = d.getAttribute("id"), q.test(d) && a.push(b[g])); return a
                    }
                }
            } if ("undefined" !== typeof m && "undefined" !== typeof k) {
                var t; l += /\/$/.test(l) ? "" : "/"; var g = function (a, b) { if (t === b) return u(l + a, b), x; if (e.e(b, "Array") || e.e(b, "NodeList")) for (var d = 0, f = b.length; d < f; d++)if (t === b[d]) return u(l + a + "/" + (d + 1), b[d]), x }; b.d(document, "mousedown", function (a) {
                    a = a || window.event; t = a.target || a.srcElement; var b = {}; for (r(m, function (a, d) {
                    b[a] = e.e(d,
                        "Function") ? d() : document.getElementById(d)
                    }); t && t !== document && r(b, g) !== x;)t = t.parentNode
                })
            }
        }
    })(); (function () { var a = mt.f, e = mt.lang, b = mt.event, d = mt.s; if ("undefined" !== typeof h.c && e.e(c.cvcf, "Array") && 0 < c.cvcf.length) { var f = { hb: function () { for (var d = c.cvcf.length, e, m = 0; m < d; m++)(e = a.ba(decodeURIComponent(c.cvcf[m]))) && b.d(e, "click", f.aa()) }, aa: function () { return function () { h.c.b.et = 86; var a = { n: "form", t: "clk" }; a.id = this.id; h.c.b.ep = d.stringify(a); h.c.h() } } }; a.Ga(function () { f.hb() }) } })();
    (function () { var a = mt.event, e = mt.s; if (c.med && "undefined" !== typeof h.c) { var b = { n: "anti", sb: 0, kb: 0, clk: 0 }, d = function () { h.c.b.et = 86; h.c.b.ep = e.stringify(b); h.c.h() }; a.d(document, "click", function () { b.clk++ }); a.d(document, "keyup", function () { b.kb = 1 }); a.d(window, "scroll", function () { b.sb++ }); a.d(window, "load", function () { setTimeout(d, 5E3) }) } })();
})();
