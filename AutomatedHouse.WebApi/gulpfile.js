var gulp = require('gulp');
var eslint = require('gulp-eslint');
var webpack = require('webpack-stream');
var argv = require('yargs').argv;
var run = require('run-sequence');

var jsFiles = [
    './Scripts/app/*.js'
];

gulp.task('eslint', eslintTask);
gulp.task('build-js', bundleJSTask);
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

function watchTask() {
    gulp.watch(jsFiles, ['build-js']);
}

function buildTask(done) {
    var dev = argv.d || argv.dev;

    console.log(dev);

    if (dev) {
        run(
            'eslint',
            'build-js',
            'watch',
            done
        );
    } else {
        run(
            'eslint',
            'build-js',
            done
        );
    }
}