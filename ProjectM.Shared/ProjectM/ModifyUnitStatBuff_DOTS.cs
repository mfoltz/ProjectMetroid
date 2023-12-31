// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyUnitStatBuff_DOTS
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyUnitStatBuff_DOTS
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StatType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModificationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseByStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueByStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public UnitStatType StatType;
    [FieldOffset(1)]
    public ModificationType ModificationType;
    [FieldOffset(4)]
    public float Value;
    [FieldOffset(8)]
    public bool IncreaseByStacks;
    [FieldOffset(12)]
    public float ValueByStacks;
    [FieldOffset(16)]
    public int Priority;
    [FieldOffset(20)]
    public ModificationId Id;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739717, XrefRangeEnd = 739719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuff_DOTS.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyUnitStatBuff_DOTS()
    {
      Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifyUnitStatBuff_DOTS));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr);
      ModifyUnitStatBuff_DOTS.NativeFieldInfoPtr_StatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, nameof (StatType));
      ModifyUnitStatBuff_DOTS.NativeFieldInfoPtr_ModificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, nameof (ModificationType));
      ModifyUnitStatBuff_DOTS.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, nameof (Value));
      ModifyUnitStatBuff_DOTS.NativeFieldInfoPtr_IncreaseByStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, nameof (IncreaseByStacks));
      ModifyUnitStatBuff_DOTS.NativeFieldInfoPtr_ValueByStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, nameof (ValueByStacks));
      ModifyUnitStatBuff_DOTS.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, nameof (Priority));
      ModifyUnitStatBuff_DOTS.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, nameof (Id));
      ModifyUnitStatBuff_DOTS.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, 100665279);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyUnitStatBuff_DOTS>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
