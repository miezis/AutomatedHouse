require('babel-core/register');

var gulp = require('gulp');
var eslint = require('gulp-eslint');
var webpack = require('webpack-stream');
var argv = require('yargs').argv;
var run = require('run-sequence');
var mincss = require('gulp-minify-css');
var concatcss = require('gulp-concat-css');

var jsFiles = [
    './Scripts/app/*.js'
];

var cssFiles = [
    './Content/*.css'
];

gulp.task('eslint', eslintTask);
gulp.task('build-js', bundleJSTask);
gulp.task('build-css', bundleCSSTask);
gulp.task('watch', watchTask);
gulp.task('build', buildTask);


function eslintTask() {
    return gulp.src(jsFiles)
        .pipe(eslint())
        .pipe(eslint.format())
        .pipe(eslint.failAfterError());
}

function bundleJSTask() {
    var dev = argv.d || argv.dev;

    var options = {
        watch: false,
        module: {
            loaders: [
                {test: /\.jsx?/, exclude: /node_modules/, loader: 'babel'}
            ]
        },
        plugins: [],
        output: { filename: 'index.js' },
        devtool: 'source-map'
    };

    if (!dev) {
        options.plugins.push(
            new webpack.webpack.optimize.UglifyJsPlugin({
                sourceMap: false,
                mangle: true,
                warnings: false
        }));
    }

    return gulp.src('./Scripts/app/index.js')
        .pipe(webpack(options))
        .pipe(gulp.dest('./Scripts/dist'));
}

function bundleCSSTask() {
    var dev = argv.d || argv.dev;

    if (dev) {
        return gulp.src(cssFiles)
            .pipe(concatcss('bundle.css'))
            .pipe(gulp.dest('./Content/dist'));
    }

    return gulp.src(cssFiles)
        .pipe(concatcss('bundle.css'))
        .pipe(mincss())
        .pipe(gulp.dest('./Content/dist'));
}

function watchTask() {
    gulp.watch(jsFiles, ['build-js']);
    gulp.watch(cssFiles, ['build-css']);
}

function buildTask(done) {
    var dev = argv.d || argv.dev;

    if (dev) {
        run(
            'eslint',
            'build-js',
            'build-css',
            'watch',
            done
        );
    } else {
        run(
            'eslint',
            'build-js',
            'build-css',
            done
        );
    }
}