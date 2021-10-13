// Copyright 2020-2021 Andreas Atteneder
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#if UNITY_2020_2_OR_NEWER

using System;
using System.IO;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace GLTFast.Export {
    public static class StreamExtension {
        
        public static unsafe void Write(this Stream stream, NativeArray<byte> array) {
            var span = new ReadOnlySpan<byte>(array.GetUnsafeReadOnlyPtr(), array.Length);
            stream.Write(span);
        }
    }
}
#endif
