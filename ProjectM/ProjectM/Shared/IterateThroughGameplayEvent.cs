// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.IterateThroughGameplayEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct IterateThroughGameplayEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BeginEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AfterEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_BeginIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Repeat;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IterateThroughGameplayEventAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public readonly GameplayEventId BeginEventId;
    [FieldOffset(8)]
    public readonly GameplayEventId TickEventId;
    [FieldOffset(16)]
    public readonly GameplayEventId EndEventId;
    [FieldOffset(24)]
    public readonly GameplayEventId AfterEventId;
    [FieldOffset(32)]
    public readonly int BeginIndex;
    [FieldOffset(36)]
    public int EndIndex;
    [FieldOffset(40)]
    public int CurrentCount;
    [FieldOffset(44)]
    public readonly bool Repeat;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118923, XrefRangeEnd = 1118927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IterateThroughGameplayEvent(IterateThroughGameplayEventAuthoring authoring)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IterateThroughGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_IterateThroughGameplayEventAuthoring_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118927, XrefRangeEnd = 1118932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IterateThroughGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IterateThroughGameplayEvent()
    {
      Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared", nameof (IterateThroughGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr);
      IterateThroughGameplayEvent.NativeFieldInfoPtr_BeginEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, nameof (BeginEventId));
      IterateThroughGameplayEvent.NativeFieldInfoPtr_TickEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, nameof (TickEventId));
      IterateThroughGameplayEvent.NativeFieldInfoPtr_EndEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, nameof (EndEventId));
      IterateThroughGameplayEvent.NativeFieldInfoPtr_AfterEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, nameof (AfterEventId));
      IterateThroughGameplayEvent.NativeFieldInfoPtr_BeginIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, nameof (BeginIndex));
      IterateThroughGameplayEvent.NativeFieldInfoPtr_EndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, nameof (EndIndex));
      IterateThroughGameplayEvent.NativeFieldInfoPtr_CurrentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, nameof (CurrentCount));
      IterateThroughGameplayEvent.NativeFieldInfoPtr_Repeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, nameof (Repeat));
      IterateThroughGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_IterateThroughGameplayEventAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, 100688752);
      IterateThroughGameplayEvent.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, 100688753);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IterateThroughGameplayEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
