// Decompiled with JetBrains decompiler
// Type: ProjectM.GameplayEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_GameplayEvent_GameplayEventId_Entity_EntityOwner_Entity_Entity_float3_float3_quaternion_0;
    [FieldOffset(0)]
    public GameplayEventId EventId;
    [FieldOffset(8)]
    public EntityOwner EntityOwner;
    [FieldOffset(16)]
    public Entity SpellSource;
    [FieldOffset(24)]
    public Entity SpellTarget;
    [FieldOffset(32)]
    public Entity Target;
    [FieldOffset(40)]
    public float3 OriginPosition;
    [FieldOffset(52)]
    public float3 Position;
    [FieldOffset(64)]
    public quaternion Rotation;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 747845, RefRangeEnd = 747868, XrefRangeStart = 747845, XrefRangeEnd = 747845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameplayEvent Create(
      GameplayEventId id,
      Entity spellSource,
      EntityOwner entityOwner,
      Entity spellTarget,
      Entity target,
      float3 originPos,
      float3 pos,
      quaternion rotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spellSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityOwner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spellTarget;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &originPos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEvent.NativeMethodInfoPtr_Create_Public_Static_GameplayEvent_GameplayEventId_Entity_EntityOwner_Entity_Entity_float3_float3_quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEvent*) IL2CPP.il2cpp_object_unbox(num);
    }

    static GameplayEvent()
    {
      Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr);
      GameplayEvent.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, nameof (EventId));
      GameplayEvent.NativeFieldInfoPtr_EntityOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, nameof (EntityOwner));
      GameplayEvent.NativeFieldInfoPtr_SpellSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, nameof (SpellSource));
      GameplayEvent.NativeFieldInfoPtr_SpellTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, nameof (SpellTarget));
      GameplayEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, nameof (Target));
      GameplayEvent.NativeFieldInfoPtr_OriginPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, nameof (OriginPosition));
      GameplayEvent.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, nameof (Position));
      GameplayEvent.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, nameof (Rotation));
      GameplayEvent.NativeMethodInfoPtr_Create_Public_Static_GameplayEvent_GameplayEventId_Entity_EntityOwner_Entity_Entity_float3_float3_quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, 100665864);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
