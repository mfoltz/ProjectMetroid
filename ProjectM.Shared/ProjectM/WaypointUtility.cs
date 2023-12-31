// Decompiled with JetBrains decompiler
// Type: ProjectM.WaypointUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class WaypointUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWaypointUnlocked_Public_Static_Boolean_EntityManager_Entity_Entity_byref_SyncedServerDebugSettings_byref_ServerGameBalanceSettings_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 732373, RefRangeEnd = 732379, XrefRangeStart = 732319, XrefRangeEnd = 732373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsWaypointUnlocked(
      EntityManager entityManager,
      Entity userEntity,
      Entity waypoint,
      [In] ref SyncedServerDebugSettings serverDebugSettings,
      [In] ref ServerGameBalanceSettings balanceSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &waypoint;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref serverDebugSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref balanceSettings;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WaypointUtility.NativeMethodInfoPtr_IsWaypointUnlocked_Public_Static_Boolean_EntityManager_Entity_Entity_byref_SyncedServerDebugSettings_byref_ServerGameBalanceSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WaypointUtility()
    {
      Il2CppClassPointerStore<WaypointUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WaypointUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointUtility>.NativeClassPtr);
      WaypointUtility.NativeMethodInfoPtr_IsWaypointUnlocked_Public_Static_Boolean_EntityManager_Entity_Entity_byref_SyncedServerDebugSettings_byref_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointUtility>.NativeClassPtr, 100664698);
    }

    public WaypointUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
