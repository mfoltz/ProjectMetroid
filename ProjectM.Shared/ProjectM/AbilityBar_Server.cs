// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityBar_Server
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
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityBar_Server
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HandledClientInterruptCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandledServerInterruptCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientInterruptCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientCastStartedCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClientCastGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellBlockDebuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellBlockResultBuffPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellBlockTriggerSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellBlockResultBuffDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSpellBlocked;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplySpellBlock_Public_Void_Entity_PrefabGUID_Single_SequenceGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSpellBlock_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearSpellBlocked_Public_Void_0;
    [FieldOffset(0)]
    public int HandledClientInterruptCounter;
    [FieldOffset(4)]
    public int HandledServerInterruptCounter;
    [FieldOffset(8)]
    public int ClientInterruptCounter;
    [FieldOffset(12)]
    public int ClientCastStartedCounter;
    [FieldOffset(16)]
    public Entity ClientCastGroup;
    [FieldOffset(24)]
    public Entity SpellBlockDebuff;
    [FieldOffset(32)]
    public PrefabGUID SpellBlockResultBuffPrefab;
    [FieldOffset(36)]
    public SequenceGUID SpellBlockTriggerSequence;
    [FieldOffset(40)]
    public float SpellBlockResultBuffDuration;
    [FieldOffset(44)]
    public bool IsSpellBlocked;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720182, RefRangeEnd = 720183, XrefRangeStart = 720182, XrefRangeEnd = 720182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ApplySpellBlock(
      Entity applier,
      PrefabGUID spellBlockResultBuffPrefab,
      float spellBlockResultBuffDuration,
      SequenceGUID spellBlockTriggerSequence)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &applier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spellBlockResultBuffPrefab;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &spellBlockResultBuffDuration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &spellBlockTriggerSequence;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBar_Server.NativeMethodInfoPtr_ApplySpellBlock_Public_Void_Entity_PrefabGUID_Single_SequenceGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720184, RefRangeEnd = 720185, XrefRangeStart = 720183, XrefRangeEnd = 720184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveSpellBlock(Entity applier)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &applier;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBar_Server.NativeMethodInfoPtr_RemoveSpellBlock_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720185, RefRangeEnd = 720186, XrefRangeStart = 720185, XrefRangeEnd = 720185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearSpellBlocked()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityBar_Server.NativeMethodInfoPtr_ClearSpellBlocked_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityBar_Server()
    {
      Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityBar_Server));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr);
      AbilityBar_Server.NativeFieldInfoPtr_HandledClientInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (HandledClientInterruptCounter));
      AbilityBar_Server.NativeFieldInfoPtr_HandledServerInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (HandledServerInterruptCounter));
      AbilityBar_Server.NativeFieldInfoPtr_ClientInterruptCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (ClientInterruptCounter));
      AbilityBar_Server.NativeFieldInfoPtr_ClientCastStartedCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (ClientCastStartedCounter));
      AbilityBar_Server.NativeFieldInfoPtr_ClientCastGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (ClientCastGroup));
      AbilityBar_Server.NativeFieldInfoPtr_SpellBlockDebuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (SpellBlockDebuff));
      AbilityBar_Server.NativeFieldInfoPtr_SpellBlockResultBuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (SpellBlockResultBuffPrefab));
      AbilityBar_Server.NativeFieldInfoPtr_SpellBlockTriggerSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (SpellBlockTriggerSequence));
      AbilityBar_Server.NativeFieldInfoPtr_SpellBlockResultBuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (SpellBlockResultBuffDuration));
      AbilityBar_Server.NativeFieldInfoPtr_IsSpellBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, nameof (IsSpellBlocked));
      AbilityBar_Server.NativeMethodInfoPtr_ApplySpellBlock_Public_Void_Entity_PrefabGUID_Single_SequenceGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, 100663649);
      AbilityBar_Server.NativeMethodInfoPtr_RemoveSpellBlock_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, 100663650);
      AbilityBar_Server.NativeMethodInfoPtr_ClearSpellBlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, 100663651);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityBar_Server>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
