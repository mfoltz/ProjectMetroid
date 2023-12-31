// Decompiled with JetBrains decompiler
// Type: ProjectM.KnockbackPower
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct KnockbackPower
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CATEGORIES;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_StunMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseWeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationFactor;
    [FieldOffset(0)]
    public int Importance;
    [FieldOffset(4)]
    public KnockbackPower._StunMode_e__FixedBuffer StunMode;
    [FieldOffset(20)]
    public KnockbackPower._UseWeaponLevel_e__FixedBuffer UseWeaponLevel;
    [FieldOffset(36)]
    public KnockbackPower._WeaponLevel_e__FixedBuffer WeaponLevel;
    [FieldOffset(52)]
    public KnockbackPower._DistanceFactor_e__FixedBuffer DistanceFactor;
    [FieldOffset(116)]
    public KnockbackPower._DurationFactor_e__FixedBuffer DurationFactor;

    static KnockbackPower()
    {
      Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KnockbackPower));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr);
      KnockbackPower.NativeFieldInfoPtr_MAX_CATEGORIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, nameof (MAX_CATEGORIES));
      KnockbackPower.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, nameof (Importance));
      KnockbackPower.NativeFieldInfoPtr_StunMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, nameof (StunMode));
      KnockbackPower.NativeFieldInfoPtr_UseWeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, nameof (UseWeaponLevel));
      KnockbackPower.NativeFieldInfoPtr_WeaponLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, nameof (WeaponLevel));
      KnockbackPower.NativeFieldInfoPtr_DistanceFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, nameof (DistanceFactor));
      KnockbackPower.NativeFieldInfoPtr_DurationFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, nameof (DurationFactor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MAX_CATEGORIES
    {
      get
      {
        int maxCategories;
        IL2CPP.il2cpp_field_static_get_value(KnockbackPower.NativeFieldInfoPtr_MAX_CATEGORIES, (void*) &maxCategories);
        return maxCategories;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KnockbackPower.NativeFieldInfoPtr_MAX_CATEGORIES, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.KnockbackPower/<StunMode>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _StunMode_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public byte FixedElementField;

      static _StunMode_e__FixedBuffer()
      {
        Il2CppClassPointerStore<KnockbackPower._StunMode_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, "<StunMode>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackPower._StunMode_e__FixedBuffer>.NativeClassPtr);
        KnockbackPower._StunMode_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower._StunMode_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackPower._StunMode_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.KnockbackPower/<UseWeaponLevel>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _UseWeaponLevel_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public bool FixedElementField;

      static _UseWeaponLevel_e__FixedBuffer()
      {
        Il2CppClassPointerStore<KnockbackPower._UseWeaponLevel_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, "<UseWeaponLevel>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackPower._UseWeaponLevel_e__FixedBuffer>.NativeClassPtr);
        KnockbackPower._UseWeaponLevel_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower._UseWeaponLevel_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackPower._UseWeaponLevel_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.KnockbackPower/<WeaponLevel>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _WeaponLevel_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public sbyte FixedElementField;

      static _WeaponLevel_e__FixedBuffer()
      {
        Il2CppClassPointerStore<KnockbackPower._WeaponLevel_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, "<WeaponLevel>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackPower._WeaponLevel_e__FixedBuffer>.NativeClassPtr);
        KnockbackPower._WeaponLevel_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower._WeaponLevel_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackPower._WeaponLevel_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.KnockbackPower/<DistanceFactor>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _DistanceFactor_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _DistanceFactor_e__FixedBuffer()
      {
        Il2CppClassPointerStore<KnockbackPower._DistanceFactor_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, "<DistanceFactor>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackPower._DistanceFactor_e__FixedBuffer>.NativeClassPtr);
        KnockbackPower._DistanceFactor_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower._DistanceFactor_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackPower._DistanceFactor_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.KnockbackPower/<DurationFactor>e__FixedBuffer")]
    [StructLayout(LayoutKind.Explicit)]
    public struct _DurationFactor_e__FixedBuffer
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
      [FieldOffset(0)]
      public float FixedElementField;

      static _DurationFactor_e__FixedBuffer()
      {
        Il2CppClassPointerStore<KnockbackPower._DurationFactor_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnockbackPower>.NativeClassPtr, "<DurationFactor>e__FixedBuffer");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackPower._DurationFactor_e__FixedBuffer>.NativeClassPtr);
        KnockbackPower._DurationFactor_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackPower._DurationFactor_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackPower._DurationFactor_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
