// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StationSounds
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Audio
{
  public static class StationSounds : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayOpenSound_Public_Static_Void_EntityManager_Entity_String_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PlayCloseSound_Public_Static_Void_EntityManager_Entity_String_GameObject_0;

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 796077, RefRangeEnd = 796092, XrefRangeStart = 796058, XrefRangeEnd = 796077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PlayOpenSound(
      EntityManager entityManager,
      Entity entity,
      string debugInfo,
      GameObject debugObject = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StationSounds.NativeMethodInfoPtr_PlayOpenSound_Public_Static_Void_EntityManager_Entity_String_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 796111, RefRangeEnd = 796126, XrefRangeStart = 796092, XrefRangeEnd = 796111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PlayCloseSound(
      EntityManager entityManager,
      Entity entity,
      string debugInfo,
      GameObject debugObject = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(debugInfo);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StationSounds.NativeMethodInfoPtr_PlayCloseSound_Public_Static_Void_EntityManager_Entity_String_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StationSounds()
    {
      Il2CppClassPointerStore<StationSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Audio", nameof (StationSounds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationSounds>.NativeClassPtr);
      StationSounds.NativeMethodInfoPtr_PlayOpenSound_Public_Static_Void_EntityManager_Entity_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationSounds>.NativeClassPtr, 100670246);
      StationSounds.NativeMethodInfoPtr_PlayCloseSound_Public_Static_Void_EntityManager_Entity_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationSounds>.NativeClassPtr, 100670247);
    }

    public StationSounds(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
