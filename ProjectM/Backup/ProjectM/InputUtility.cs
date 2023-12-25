// Decompiled with JetBrains decompiler
// Type: ProjectM.InputUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class InputUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseAimPosition_Public_Static_float3_float3_Camera_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003996, XrefRangeEnd = 1004005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float3 GetMouseAimPosition(float3 cameraLookAtPosition, Camera camera)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cameraLookAtPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InputUtility.NativeMethodInfoPtr_GetMouseAimPosition_Public_Static_float3_float3_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InputUtility()
    {
      Il2CppClassPointerStore<InputUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InputUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputUtility>.NativeClassPtr);
      InputUtility.NativeMethodInfoPtr_GetMouseAimPosition_Public_Static_float3_float3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUtility>.NativeClassPtr, 100677832);
    }

    public InputUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
