// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleStatModifiersEditor
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
  public class CastleStatModifiersEditor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TickPeriod;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageResistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SafetyBoxLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_TombLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_VerminNestLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrisonCellLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeartLimits;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleLimit;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758964, RefRangeEnd = 758965, XrefRangeStart = 758954, XrefRangeEnd = 758964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleStatModifiersEditor.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleStatModifiersEditor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleStatModifiersEditor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleStatModifiersEditor()
    {
      Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CastleStatModifiersEditor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr);
      CastleStatModifiersEditor.NativeFieldInfoPtr_TickPeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, nameof (TickPeriod));
      CastleStatModifiersEditor.NativeFieldInfoPtr_DamageResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, nameof (DamageResistance));
      CastleStatModifiersEditor.NativeFieldInfoPtr_SafetyBoxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, nameof (SafetyBoxLimit));
      CastleStatModifiersEditor.NativeFieldInfoPtr_TombLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, nameof (TombLimit));
      CastleStatModifiersEditor.NativeFieldInfoPtr_VerminNestLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, nameof (VerminNestLimit));
      CastleStatModifiersEditor.NativeFieldInfoPtr_PrisonCellLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, nameof (PrisonCellLimit));
      CastleStatModifiersEditor.NativeFieldInfoPtr_HeartLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, nameof (HeartLimits));
      CastleStatModifiersEditor.NativeFieldInfoPtr_CastleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, nameof (CastleLimit));
      CastleStatModifiersEditor.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, 100666983);
      CastleStatModifiersEditor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleStatModifiersEditor>.NativeClassPtr, 100666984);
    }

    public CastleStatModifiersEditor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TickPeriod
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_TickPeriod));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_TickPeriod)) = value;
      }
    }

    public unsafe float DamageResistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_DamageResistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_DamageResistance)) = value;
      }
    }

    public unsafe byte SafetyBoxLimit
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_SafetyBoxLimit));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_SafetyBoxLimit)) = value;
      }
    }

    public unsafe byte TombLimit
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_TombLimit));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_TombLimit)) = value;
      }
    }

    public unsafe byte VerminNestLimit
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_VerminNestLimit));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_VerminNestLimit)) = value;
      }
    }

    public unsafe byte PrisonCellLimit
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_PrisonCellLimit));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_PrisonCellLimit)) = value;
      }
    }

    public unsafe HeartLimits HeartLimits
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_HeartLimits));
        return pointer == System.IntPtr.Zero ? (HeartLimits) null : new HeartLimits(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_HeartLimits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe byte CastleLimit
    {
      get
      {
        return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_CastleLimit));
      }
      [param: In] set
      {
        *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleStatModifiersEditor.NativeFieldInfoPtr_CastleLimit)) = value;
      }
    }
  }
}
