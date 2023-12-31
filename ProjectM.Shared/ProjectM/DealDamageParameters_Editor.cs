// Decompiled with JetBrains decompiler
// Type: ProjectM.DealDamageParameters_Editor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class DealDamageParameters_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MainFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawDamageValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawDamagePercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowSCT;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsDoT;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCC;
    private static readonly System.IntPtr NativeFieldInfoPtr_CauseDurabilityLoss;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryAttack;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_DealDamageParameters_0;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 737213, RefRangeEnd = 737223, XrefRangeStart = 737207, XrefRangeEnd = 737213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DealDamageParameters Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageParameters_Editor.NativeMethodInfoPtr_Convert_Public_DealDamageParameters_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DealDamageParameters*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DealDamageParameters_Editor()
    {
      Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DealDamageParameters_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr);
      DealDamageParameters_Editor.NativeFieldInfoPtr_MainFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (MainFactor));
      DealDamageParameters_Editor.NativeFieldInfoPtr_MainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (MainType));
      DealDamageParameters_Editor.NativeFieldInfoPtr_ResourceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (ResourceModifier));
      DealDamageParameters_Editor.NativeFieldInfoPtr_StaggerFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (StaggerFactor));
      DealDamageParameters_Editor.NativeFieldInfoPtr_MaterialModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (MaterialModifiers));
      DealDamageParameters_Editor.NativeFieldInfoPtr_RawDamageValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (RawDamageValue));
      DealDamageParameters_Editor.NativeFieldInfoPtr_RawDamagePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (RawDamagePercent));
      DealDamageParameters_Editor.NativeFieldInfoPtr_ShowSCT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (ShowSCT));
      DealDamageParameters_Editor.NativeFieldInfoPtr_IsDoT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (IsDoT));
      DealDamageParameters_Editor.NativeFieldInfoPtr_IgnoreCC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (IgnoreCC));
      DealDamageParameters_Editor.NativeFieldInfoPtr_CauseDurabilityLoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (CauseDurabilityLoss));
      DealDamageParameters_Editor.NativeFieldInfoPtr_PrimaryAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, nameof (PrimaryAttack));
      DealDamageParameters_Editor.NativeMethodInfoPtr_Convert_Public_DealDamageParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, 100665115);
    }

    public DealDamageParameters_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public DealDamageParameters_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageParameters_Editor>.NativeClassPtr, data));
    }

    public unsafe float MainFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_MainFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_MainFactor)) = value;
      }
    }

    public unsafe MainDamageType MainType
    {
      get
      {
        return *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_MainType));
      }
      [param: In] set
      {
        *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_MainType)) = value;
      }
    }

    public unsafe float ResourceModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_ResourceModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_ResourceModifier)) = value;
      }
    }

    public unsafe float StaggerFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_StaggerFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_StaggerFactor)) = value;
      }
    }

    public unsafe DamageModifierSettings MaterialModifiers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_MaterialModifiers));
        return pointer == System.IntPtr.Zero ? (DamageModifierSettings) null : new DamageModifierSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_MaterialModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float RawDamageValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_RawDamageValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_RawDamageValue)) = value;
      }
    }

    public unsafe float RawDamagePercent
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_RawDamagePercent));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_RawDamagePercent)) = value;
      }
    }

    public unsafe bool ShowSCT
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_ShowSCT));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_ShowSCT)) = value;
      }
    }

    public unsafe bool IsDoT
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_IsDoT));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_IsDoT)) = value;
      }
    }

    public unsafe bool IgnoreCC
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_IgnoreCC));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_IgnoreCC)) = value;
      }
    }

    public unsafe bool CauseDurabilityLoss
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_CauseDurabilityLoss));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_CauseDurabilityLoss)) = value;
      }
    }

    public unsafe bool PrimaryAttack
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_PrimaryAttack));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DealDamageParameters_Editor.NativeFieldInfoPtr_PrimaryAttack)) = value;
      }
    }
  }
}
