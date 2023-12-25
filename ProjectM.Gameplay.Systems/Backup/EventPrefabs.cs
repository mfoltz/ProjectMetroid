// Decompiled with JetBrains decompiler
// Type: ProjectM.EventPrefabs
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
  [StructLayout(LayoutKind.Explicit)]
  public struct EventPrefabs
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCastInterruptedEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityPreCastEndedEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityPostCastEndedEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCastEndedEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityCastStartedEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityPreCastFinishedEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityPostCastFinishedEvent;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_EventPrefabs_EntityManager_0;
    [FieldOffset(0)]
    public Entity AbilityCastInterruptedEvent;
    [FieldOffset(8)]
    public Entity AbilityPreCastEndedEvent;
    [FieldOffset(16)]
    public Entity AbilityPostCastEndedEvent;
    [FieldOffset(24)]
    public Entity AbilityCastEndedEvent;
    [FieldOffset(32)]
    public Entity AbilityCastStartedEvent;
    [FieldOffset(40)]
    public Entity AbilityPreCastFinishedEvent;
    [FieldOffset(48)]
    public Entity AbilityPostCastFinishedEvent;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1369972, RefRangeEnd = 1369974, XrefRangeStart = 1369897, XrefRangeEnd = 1369972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EventPrefabs Create(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventPrefabs.NativeMethodInfoPtr_Create_Public_Static_EventPrefabs_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EventPrefabs*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EventPrefabs()
    {
      Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (EventPrefabs));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr);
      EventPrefabs.NativeFieldInfoPtr_AbilityCastInterruptedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, nameof (AbilityCastInterruptedEvent));
      EventPrefabs.NativeFieldInfoPtr_AbilityPreCastEndedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, nameof (AbilityPreCastEndedEvent));
      EventPrefabs.NativeFieldInfoPtr_AbilityPostCastEndedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, nameof (AbilityPostCastEndedEvent));
      EventPrefabs.NativeFieldInfoPtr_AbilityCastEndedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, nameof (AbilityCastEndedEvent));
      EventPrefabs.NativeFieldInfoPtr_AbilityCastStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, nameof (AbilityCastStartedEvent));
      EventPrefabs.NativeFieldInfoPtr_AbilityPreCastFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, nameof (AbilityPreCastFinishedEvent));
      EventPrefabs.NativeFieldInfoPtr_AbilityPostCastFinishedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, nameof (AbilityPostCastFinishedEvent));
      EventPrefabs.NativeMethodInfoPtr_Create_Public_Static_EventPrefabs_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, 100664336);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventPrefabs>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
