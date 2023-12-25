// Decompiled with JetBrains decompiler
// Type: VOCredits
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public sealed class VOCredits : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_UnitName;
  private static readonly System.IntPtr NativeFieldInfoPtr_GenderPostfix;
  private static readonly System.IntPtr NativeFieldInfoPtr_VoiceActor;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VOCredits_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1207692, XrefRangeEnd = 1207695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int CompareTo(VOCredits other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VOCredits.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VOCredits_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  static VOCredits()
  {
    Il2CppClassPointerStore<VOCredits>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (VOCredits));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VOCredits>.NativeClassPtr);
    VOCredits.NativeFieldInfoPtr_UnitName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOCredits>.NativeClassPtr, nameof (UnitName));
    VOCredits.NativeFieldInfoPtr_GenderPostfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOCredits>.NativeClassPtr, nameof (GenderPostfix));
    VOCredits.NativeFieldInfoPtr_VoiceActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOCredits>.NativeClassPtr, nameof (VoiceActor));
    VOCredits.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VOCredits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOCredits>.NativeClassPtr, 100663496);
  }

  public VOCredits(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public VOCredits()
  {
    // ISSUE: cast to a reference type
    // ISSUE: untyped stack allocation
    System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VOCredits>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    // ISSUE: explicit constructor call
    base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VOCredits>.NativeClassPtr, data));
  }

  public unsafe LocalizationKey UnitName
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOCredits.NativeFieldInfoPtr_UnitName));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOCredits.NativeFieldInfoPtr_UnitName)) = value;
    }
  }

  public unsafe LocalizationKey GenderPostfix
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOCredits.NativeFieldInfoPtr_GenderPostfix));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOCredits.NativeFieldInfoPtr_GenderPostfix)) = value;
    }
  }

  public unsafe string VoiceActor
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOCredits.NativeFieldInfoPtr_VoiceActor)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOCredits.NativeFieldInfoPtr_VoiceActor), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
