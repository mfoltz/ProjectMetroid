// Decompiled with JetBrains decompiler
// Type: ProjectM.DeathUtilities
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class DeathUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Public_Static_Void_EntityManager_Entity_Dead_DeathEvent_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1004660, RefRangeEnd = 1004663, XrefRangeStart = 1004647, XrefRangeEnd = 1004660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Kill(
      EntityManager entityManager,
      Entity killed,
      Dead dead,
      DeathEvent deathEvent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &killed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dead;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deathEvent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeathUtilities.NativeMethodInfoPtr_Kill_Public_Static_Void_EntityManager_Entity_Dead_DeathEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeathUtilities()
    {
      Il2CppClassPointerStore<DeathUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DeathUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathUtilities>.NativeClassPtr);
      DeathUtilities.NativeMethodInfoPtr_Kill_Public_Static_Void_EntityManager_Entity_Dead_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathUtilities>.NativeClassPtr, 100677916);
    }

    public DeathUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
