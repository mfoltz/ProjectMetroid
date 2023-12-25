// Decompiled with JetBrains decompiler
// Type: ProjectM.EventQueries
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EventQueries
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAbilityCastStartedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAbilityPreCastFinishedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAbilityPostCastFinishedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAbilityCastEndedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAbilityPreCastEndedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAbilityPostCastEndedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveAbilityInterruptedEventQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_EventQueries_SystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public EntityQuery RemoveAbilityCastStartedEventQuery;
    [FieldOffset(16)]
    public EntityQuery RemoveAbilityPreCastFinishedEventQuery;
    [FieldOffset(32)]
    public EntityQuery RemoveAbilityPostCastFinishedEventQuery;
    [FieldOffset(48)]
    public EntityQuery RemoveAbilityCastEndedEventQuery;
    [FieldOffset(64)]
    public EntityQuery RemoveAbilityPreCastEndedEventQuery;
    [FieldOffset(80)]
    public EntityQuery RemoveAbilityPostCastEndedEventQuery;
    [FieldOffset(96)]
    public EntityQuery RemoveAbilityInterruptedEventQuery;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1370024, RefRangeEnd = 1370026, XrefRangeStart = 1369974, XrefRangeEnd = 1370024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EventQueries Create(SystemBase system)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventQueries.NativeMethodInfoPtr_Create_Public_Static_EventQueries_SystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EventQueries*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1370033, RefRangeEnd = 1370034, XrefRangeStart = 1370026, XrefRangeEnd = 1370033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EventQueries.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EventQueries()
    {
      Il2CppClassPointerStore<EventQueries>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (EventQueries));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventQueries>.NativeClassPtr);
      EventQueries.NativeFieldInfoPtr_RemoveAbilityCastStartedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, nameof (RemoveAbilityCastStartedEventQuery));
      EventQueries.NativeFieldInfoPtr_RemoveAbilityPreCastFinishedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, nameof (RemoveAbilityPreCastFinishedEventQuery));
      EventQueries.NativeFieldInfoPtr_RemoveAbilityPostCastFinishedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, nameof (RemoveAbilityPostCastFinishedEventQuery));
      EventQueries.NativeFieldInfoPtr_RemoveAbilityCastEndedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, nameof (RemoveAbilityCastEndedEventQuery));
      EventQueries.NativeFieldInfoPtr_RemoveAbilityPreCastEndedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, nameof (RemoveAbilityPreCastEndedEventQuery));
      EventQueries.NativeFieldInfoPtr_RemoveAbilityPostCastEndedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, nameof (RemoveAbilityPostCastEndedEventQuery));
      EventQueries.NativeFieldInfoPtr_RemoveAbilityInterruptedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, nameof (RemoveAbilityInterruptedEventQuery));
      EventQueries.NativeMethodInfoPtr_Create_Public_Static_EventQueries_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, 100664337);
      EventQueries.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, 100664338);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventQueries>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
