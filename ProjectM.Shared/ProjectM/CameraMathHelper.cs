// Decompiled with JetBrains decompiler
// Type: ProjectM.CameraMathHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class CameraMathHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SuperSmoothLerp_Public_Static_Single_Single_Single_Single_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SuperSmoothLerp_Public_Static_Vector3_Vector3_Vector3_Vector3_Single_Single_0;

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 722564, RefRangeEnd = 722571, XrefRangeStart = 722562, XrefRangeEnd = 722564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float SuperSmoothLerp(
      float pastSource,
      float pastTarget,
      float target,
      float deltaTime,
      float speed)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pastSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pastTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &speed;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMathHelper.NativeMethodInfoPtr_SuperSmoothLerp_Public_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 722573, RefRangeEnd = 722577, XrefRangeStart = 722571, XrefRangeEnd = 722573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector3 SuperSmoothLerp(
      Vector3 pastSource,
      Vector3 pastTarget,
      Vector3 target,
      float deltaTime,
      float speed)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pastSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pastTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &speed;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraMathHelper.NativeMethodInfoPtr_SuperSmoothLerp_Public_Static_Vector3_Vector3_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CameraMathHelper()
    {
      Il2CppClassPointerStore<CameraMathHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CameraMathHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMathHelper>.NativeClassPtr);
      CameraMathHelper.NativeMethodInfoPtr_SuperSmoothLerp_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMathHelper>.NativeClassPtr, 100663803);
      CameraMathHelper.NativeMethodInfoPtr_SuperSmoothLerp_Public_Static_Vector3_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMathHelper>.NativeClassPtr, 100663804);
    }

    public CameraMathHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
