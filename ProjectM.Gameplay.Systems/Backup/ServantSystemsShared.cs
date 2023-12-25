// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantSystemsShared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class ServantSystemsShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Summon_Public_Static_Void_byref_ServantCoffinstation_Entity_EntityManager_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1420072, RefRangeEnd = 1420074, XrefRangeStart = 1420052, XrefRangeEnd = 1420072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Summon(
      [In] ref ServantCoffinstation station,
      Entity targetWorkstation,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref station;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetWorkstation;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantSystemsShared.NativeMethodInfoPtr_Summon_Public_Static_Void_byref_ServantCoffinstation_Entity_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantSystemsShared()
    {
      Il2CppClassPointerStore<ServantSystemsShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ServantSystemsShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantSystemsShared>.NativeClassPtr);
      ServantSystemsShared.NativeMethodInfoPtr_Summon_Public_Static_Void_byref_ServantCoffinstation_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantSystemsShared>.NativeClassPtr, 100669569);
    }

    public ServantSystemsShared(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
