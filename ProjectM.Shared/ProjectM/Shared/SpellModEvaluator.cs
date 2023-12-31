// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModEvaluator
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Shared
{
  [Serializable]
  public class SpellModEvaluator : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ModType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatModificationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisplayFormat;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisplayDecimals;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildBlob_Public_SpellModBlobValue_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildUIBlob_Public_SpellModBlobValue_UI_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798513, XrefRangeEnd = 798516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedKeyValue GetLocalizedKeyValue(float power)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &power;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellModEvaluator.NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedKeyValue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798516, XrefRangeEnd = 798517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModBlobValue BuildBlob(UnityEngine.Object source)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModEvaluator.NativeMethodInfoPtr_BuildBlob_Public_SpellModBlobValue_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpellModBlobValue*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 798517, XrefRangeEnd = 798518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModBlobValue_UI BuildUIBlob()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellModEvaluator.NativeMethodInfoPtr_BuildUIBlob_Public_SpellModBlobValue_UI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SpellModBlobValue_UI*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellModEvaluator()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellModEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellModEvaluator()
    {
      Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModEvaluator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr);
      SpellModEvaluator.NativeFieldInfoPtr_ModType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (ModType));
      SpellModEvaluator.NativeFieldInfoPtr_StatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (StatType));
      SpellModEvaluator.NativeFieldInfoPtr_StatModificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (StatModificationType));
      SpellModEvaluator.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (Name));
      SpellModEvaluator.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (Range));
      SpellModEvaluator.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (Curve));
      SpellModEvaluator.NativeFieldInfoPtr_DisplayFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (DisplayFormat));
      SpellModEvaluator.NativeFieldInfoPtr_DisplayDecimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (DisplayDecimals));
      SpellModEvaluator.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, nameof (Prefab));
      SpellModEvaluator.NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, 100670410);
      SpellModEvaluator.NativeMethodInfoPtr_BuildBlob_Public_SpellModBlobValue_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, 100670411);
      SpellModEvaluator.NativeMethodInfoPtr_BuildUIBlob_Public_SpellModBlobValue_UI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, 100670412);
      SpellModEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModEvaluator>.NativeClassPtr, 100670413);
    }

    public SpellModEvaluator(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpellModBlobValue.ModType ModType
    {
      get
      {
        return *(SpellModBlobValue.ModType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_ModType));
      }
      [param: In] set
      {
        *(SpellModBlobValue.ModType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_ModType)) = value;
      }
    }

    public unsafe UnitStatType StatType
    {
      get
      {
        return *(UnitStatType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_StatType));
      }
      [param: In] set
      {
        *(UnitStatType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_StatType)) = value;
      }
    }

    public unsafe ModificationType_Editor StatModificationType
    {
      get
      {
        return *(ModificationType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_StatModificationType));
      }
      [param: In] set
      {
        *(ModificationType_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_StatModificationType)) = value;
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Vector2 Range
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe CurveInstance Curve
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_Curve));
        return pointer == System.IntPtr.Zero ? (CurveInstance) null : new CurveInstance(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpellModBlobValue_UI.ValueNumericFormat DisplayFormat
    {
      get
      {
        return *(SpellModBlobValue_UI.ValueNumericFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_DisplayFormat));
      }
      [param: In] set
      {
        *(SpellModBlobValue_UI.ValueNumericFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_DisplayFormat)) = value;
      }
    }

    public unsafe int DisplayDecimals
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_DisplayDecimals));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_DisplayDecimals)) = value;
      }
    }

    public unsafe PrefabGuidComponent Prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_Prefab));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellModEvaluator.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
