# Copyright 2019 The MediaPipe Authors.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

licenses(["notice"])  # Apache License 2.0

exports_files(["LICENSE"])

package(default_visibility = ["//visibility:public"])

cc_library(
    name = "glog",
    visibility = ["//visibility:public"],
    deps = select({
        "@com_google_mediapipe//mediapipe:android_x86": [
            "@com_github_glog_glog_no_gflags//:glog",
        ],
        "@com_google_mediapipe//mediapipe:android_x86_64": [
            "@com_github_glog_glog_no_gflags//:glog",
        ],
        "@com_google_mediapipe//mediapipe:android_armeabi": [
            "@com_github_glog_glog_no_gflags//:glog",
        ],
        "@com_google_mediapipe//mediapipe:android_arm": [
            "@com_github_glog_glog_no_gflags//:glog",
        ],
        "@com_google_mediapipe//mediapipe:android_arm64": [
            "@com_github_glog_glog_no_gflags//:glog",
        ],
        "@com_google_mediapipe//mediapipe:ios": [
            "@com_github_glog_glog_no_gflags//:glog",
        ],
        "@com_google_mediapipe//mediapipe:macos": [
            "@com_github_glog_glog//:glog",
        ],
        "@com_google_mediapipe//mediapipe:windows": [
            "@com_github_glog_glog//:glog",
        ],
        "//conditions:default": [
            "@com_github_glog_glog//:glog",
        ],
    }),
)

alias(
    name = "opencv",
    actual = select({
        "@com_google_mediapipe//mediapipe:android_x86": "@android_opencv//:libopencv_x86",
        "@com_google_mediapipe//mediapipe:android_x86_64": "@android_opencv//:libopencv_x86_64",
        "@com_google_mediapipe//mediapipe:android_armeabi": "@android_opencv//:libopencv_armeabi-v7a",
        "@com_google_mediapipe//mediapipe:android_arm": "@android_opencv//:libopencv_armeabi-v7a",
        "@com_google_mediapipe//mediapipe:android_arm64": "@android_opencv//:libopencv_arm64-v8a",
        "@com_google_mediapipe//mediapipe:ios": "@ios_opencv//:opencv",
        "@com_google_mediapipe//mediapipe:macos": "@macos_opencv//:opencv",
        "@com_google_mediapipe//mediapipe:windows": "@windows_opencv//:opencv",
        "//conditions:default": "@linux_opencv//:opencv",
    }),
    visibility = ["//visibility:public"],
)

cc_library(
    name = "libffmpeg",
    visibility = ["//visibility:public"],
    deps = select({
        "@com_google_mediapipe//mediapipe:android_x86": [],
        "@com_google_mediapipe//mediapipe:android_x86_64": [],
        "@com_google_mediapipe//mediapipe:android_armeabi": [],
        "@com_google_mediapipe//mediapipe:android_arm": [],
        "@com_google_mediapipe//mediapipe:android_arm64": [],
        "@com_google_mediapipe//mediapipe:ios": [],
        "@com_google_mediapipe//mediapipe:macos": [
            "@macos_ffmpeg//:libffmpeg",
        ],
        "//conditions:default": [
            "@linux_ffmpeg//:libffmpeg",
        ],
    }),
)

android_library(
    name = "androidx_annotation",
    exports = [
        "@maven//:androidx_annotation_annotation",
    ],
)

android_library(
    name = "androidx_appcompat",
    exports = [
        "@maven//:androidx_appcompat_appcompat",
    ],
)

android_library(
    name = "androidx_constraint_layout",
    exports = [
        "@maven//:androidx_constraintlayout_constraintlayout",
    ],
)

android_library(
    name = "androidx_core",
    exports = [
        "@maven//:androidx_core_core",
    ],
)

android_library(
    name = "androidx_legacy_support_v4",
    exports = [
        "@maven//:androidx_legacy_legacy_support_v4",
    ],
)

android_library(
    name = "androidx_material",
    exports = [
        "@maven//:com_google_android_material_material",
    ],
)

android_library(
    name = "androidx_recyclerview",
    exports = [
        "@maven//:androidx_recyclerview_recyclerview",
    ],
)

android_library(
    name = "camerax_core",
    exports = [
        "@maven//:androidx_camera_camera_core",
    ],
)

android_library(
    name = "camera2",
    exports = [
        "@maven//:androidx_camera_camera_camera2",
    ],
)
