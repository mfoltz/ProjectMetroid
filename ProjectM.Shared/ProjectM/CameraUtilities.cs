// Decompiled with JetBrains decompiler
// Type: ProjectM.CameraUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class CameraUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_FindActiveCamera_Public_Static_Camera_EntityManager_EntityQuery_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 722621, RefRangeEnd = 722623, XrefRangeStart = 722592, XrefRangeEnd = 722621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Camera FindActiveCamera(
      EntityManager entityManager,
      EntityQuery cameraUserQuery)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cameraUserQuery;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CameraUtilities.NativeMethodInfoPtr_FindActiveCamera_Public_Static_Camera_EntityManager_EntityQuery_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Camera) null : new Camera(pointer);
    }

    static CameraUtilities()
    {
      Il2CppClassPointerStore<CameraUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CameraUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraUtilities>.NativeClassPtr);
      CameraUtilities.NativeMethodInfoPtr_FindActiveCamera_Public_Static_Camera_EntityManager_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUtilities>.NativeClassPtr, 100663811);
    }

    public CameraUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
