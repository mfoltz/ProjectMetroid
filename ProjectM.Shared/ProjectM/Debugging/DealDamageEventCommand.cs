// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.DealDamageEventCommand
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DealDamageEventCommand
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DealDamageEvent;
    private static readonly System.IntPtr NativeFieldInfoPtr_FinalDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_FinalModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealDamageResult;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetType;
    [FieldOffset(0)]
    public DealDamageEvent DealDamageEvent;
    [FieldOffset(128)]
    public float FinalDamage;
    [FieldOffset(132)]
    public EntityCategory TargetEntityCategory;
    [FieldOffset(140)]
    public DealDamageEventCommand.Modifiers FinalModifiers;
    [FieldOffset(180)]
    public DealDamageResultEnum DealDamageResult;
    [FieldOffset(184)]
    public DealDamageTargetTypeEnum DealerType;
    [FieldOffset(188)]
    public DealDamageTargetTypeEnum TargetType;

    static DealDamageEventCommand()
    {
      Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (DealDamageEventCommand));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr);
      DealDamageEventCommand.NativeFieldInfoPtr_DealDamageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, nameof (DealDamageEvent));
      DealDamageEventCommand.NativeFieldInfoPtr_FinalDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, nameof (FinalDamage));
      DealDamageEventCommand.NativeFieldInfoPtr_TargetEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, nameof (TargetEntityCategory));
      DealDamageEventCommand.NativeFieldInfoPtr_FinalModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, nameof (FinalModifiers));
      DealDamageEventCommand.NativeFieldInfoPtr_DealDamageResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, nameof (DealDamageResult));
      DealDamageEventCommand.NativeFieldInfoPtr_DealerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, nameof (DealerType));
      DealDamageEventCommand.NativeFieldInfoPtr_TargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, nameof (TargetType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Modifiers
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EventModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageReduction;
      private static readonly System.IntPtr NativeFieldInfoPtr_PveDamageModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageMaterialModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResistanceModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageReductionModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_Power;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResourceModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_PhysicalAttackModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageType;
      [FieldOffset(0)]
      public float EventModifier;
      [FieldOffset(4)]
      public float DamageReduction;
      [FieldOffset(8)]
      public float PveDamageModifier;
      [FieldOffset(12)]
      public float DamageMaterialModifier;
      [FieldOffset(16)]
      public float ResistanceModifier;
      [FieldOffset(20)]
      public float DamageReductionModifier;
      [FieldOffset(24)]
      public float Power;
      [FieldOffset(28)]
      public float ResourceModifier;
      [FieldOffset(32)]
      public float PhysicalAttackModifier;
      [FieldOffset(36)]
      public DamageTypeEnum DamageType;

      static Modifiers()
      {
        Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealDamageEventCommand>.NativeClassPtr, nameof (Modifiers));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr);
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_EventModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (EventModifier));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_DamageReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (DamageReduction));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_PveDamageModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (PveDamageModifier));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_DamageMaterialModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (DamageMaterialModifier));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_ResistanceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (ResistanceModifier));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_DamageReductionModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (DamageReductionModifier));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (Power));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_ResourceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (ResourceModifier));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_PhysicalAttackModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (PhysicalAttackModifier));
        DealDamageEventCommand.Modifiers.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, nameof (DamageType));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageEventCommand.Modifiers>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
