// Decompiled with JetBrains decompiler
// Type: ProjectM.RelocationData_CombatArea
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class RelocationData_CombatArea : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCombatAreaRelocation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Distance;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecalculationFrequencyMinMax;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RelocationData_CombatArea()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelocationData_CombatArea>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RelocationData_CombatArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RelocationData_CombatArea()
    {
      Il2CppClassPointerStore<RelocationData_CombatArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RelocationData_CombatArea));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelocationData_CombatArea>.NativeClassPtr);
      RelocationData_CombatArea.NativeFieldInfoPtr_UseCombatAreaRelocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelocationData_CombatArea>.NativeClassPtr, nameof (UseCombatAreaRelocation));
      RelocationData_CombatArea.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelocationData_CombatArea>.NativeClassPtr, nameof (Distance));
      RelocationData_CombatArea.NativeFieldInfoPtr_RecalculationFrequencyMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelocationData_CombatArea>.NativeClassPtr, nameof (RecalculationFrequencyMinMax));
      RelocationData_CombatArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelocationData_CombatArea>.NativeClassPtr, 100663973);
    }

    public RelocationData_CombatArea(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool UseCombatAreaRelocation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationData_CombatArea.NativeFieldInfoPtr_UseCombatAreaRelocation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationData_CombatArea.NativeFieldInfoPtr_UseCombatAreaRelocation)) = value;
      }
    }

    public unsafe float Distance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationData_CombatArea.NativeFieldInfoPtr_Distance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationData_CombatArea.NativeFieldInfoPtr_Distance)) = value;
      }
    }

    public unsafe Vector2 RecalculationFrequencyMinMax
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationData_CombatArea.NativeFieldInfoPtr_RecalculationFrequencyMinMax));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RelocationData_CombatArea.NativeFieldInfoPtr_RecalculationFrequencyMinMax)) = value;
      }
    }
  }
}
