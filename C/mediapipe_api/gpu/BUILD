package(
    default_visibility = ["//visibility:public"],
)

cc_library(
    name = "gl_base",
    srcs = ["gl_base.cc"],
    hdrs = ["gl_base.h"],
    deps = [
        "//mediapipe_api:common",
        "@com_google_mediapipe//mediapipe/gpu:gl_base",
    ],
    alwayslink = True,
)

cc_library(
    name = "gl_calculator_helper",
    srcs = ["gl_calculator_helper.cc"],
    hdrs = ["gl_calculator_helper.h"],
    deps = [
        "//mediapipe_api:common",
        "//mediapipe_api/framework/port:status",
        "@com_google_mediapipe//mediapipe/gpu:gl_calculator_helper",
    ],
    alwayslink = True,
)

cc_library(
    name = "gl_context",
    srcs = ["gl_context.cc"],
    hdrs = ["gl_context.h"],
    deps = [
        "//mediapipe_api:common",
        "@com_google_mediapipe//mediapipe/gpu:gl_context",
    ],
    alwayslink = True,
)

cc_library(
    name = "gl_texture_buffer",
    srcs = ["gl_texture_buffer.cc"],
    hdrs = ["gl_texture_buffer.h"],
    deps = [
        "//mediapipe_api:common",
        "@com_google_mediapipe//mediapipe/gpu:gl_texture_buffer",
    ],
    alwayslink = True,
)

cc_library(
    name = "gpu_buffer",
    srcs = ["gpu_buffer.cc"],
    hdrs = ["gpu_buffer.h"],
    deps = [
        ":gl_texture_buffer",
        "//mediapipe_api:common",
        "//mediapipe_api/framework:packet",
        "//mediapipe_api/framework/port:status",
        "//mediapipe_api/framework/port:statusor",
        "@com_google_mediapipe//mediapipe/gpu:gpu_buffer",
    ],
    alwayslink = True,
)

cc_library(
    name = "gpu_buffer_format",
    srcs = ["gpu_buffer_format.cc"],
    hdrs = ["gpu_buffer_format.h"],
    deps = [
        "//mediapipe_api:common",
        "@com_google_mediapipe//mediapipe/gpu:gpu_buffer_format",
    ],
    alwayslink = True,
)

cc_library(
    name = "gpu_shared_data_internal",
    srcs = ["gpu_shared_data_internal.cc"],
    hdrs = ["gpu_shared_data_internal.h"],
    deps = [
        "//mediapipe_api:common",
        "//mediapipe_api/framework/port:status",
        "//mediapipe_api/framework/port:statusor",
        "@com_google_mediapipe//mediapipe/gpu:gpu_shared_data_internal",
    ],
    alwayslink = True,
)
