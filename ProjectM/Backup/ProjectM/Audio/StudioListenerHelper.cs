// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StudioListenerHelper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM.Audio
{
  public static class StudioListenerHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableListener_Public_Static_Void_ComponentSystem_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableListener_Public_Static_Void_SystemBase_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnableListener_Public_Static_Void_ComponentSystem_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EnableListener_Public_Static_Void_SystemBase_EntityManager_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144005, XrefRangeEnd = 1144019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DisableListener(
      ComponentSystem componentSystem,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioListenerHelper.NativeMethodInfoPtr_DisableListener_Public_Static_Void_ComponentSystem_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1144033, RefRangeEnd = 1144034, XrefRangeStart = 1144019, XrefRangeEnd = 1144033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DisableListener(SystemBase systemBase, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioListenerHelper.NativeMethodInfoPtr_DisableListener_Public_Static_Void_SystemBase_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144034, XrefRangeEnd = 1144041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void EnableListener(
      ComponentSystem compSystem,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioListenerHelper.NativeMethodInfoPtr_EnableListener_Public_Static_Void_ComponentSystem_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1144048, RefRangeEnd = 1144049, XrefRangeStart = 1144041, XrefRangeEnd = 1144048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void EnableListener(SystemBase systemBase, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioListenerHelper.NativeMethodInfoPtr_EnableListener_Public_Static_Void_SystemBase_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StudioListenerHelper()
    {
      Il2CppClassPointerStore<StudioListenerHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StudioListenerHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioListenerHelper>.NativeClassPtr);
      StudioListenerHelper.NativeMethodInfoPtr_DisableListener_Public_Static_Void_ComponentSystem_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioListenerHelper>.NativeClassPtr, 100690560);
      StudioListenerHelper.NativeMethodInfoPtr_DisableListener_Public_Static_Void_SystemBase_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioListenerHelper>.NativeClassPtr, 100690561);
      StudioListenerHelper.NativeMethodInfoPtr_EnableListener_Public_Static_Void_ComponentSystem_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioListenerHelper>.NativeClassPtr, 100690562);
      StudioListenerHelper.NativeMethodInfoPtr_EnableListener_Public_Static_Void_SystemBase_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioListenerHelper>.NativeClassPtr, 100690563);
    }

    public StudioListenerHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
