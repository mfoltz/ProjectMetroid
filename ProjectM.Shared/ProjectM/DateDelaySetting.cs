// Decompiled with JetBrains decompiler
// Type: ProjectM.DateDelaySetting
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
  public class DateDelaySetting : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_From;
    private static readonly IntPtr NativeFieldInfoPtr_To;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DateDelaySetting()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateDelaySetting>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DateDelaySetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DateDelaySetting()
    {
      Il2CppClassPointerStore<DateDelaySetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DateDelaySetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateDelaySetting>.NativeClassPtr);
      DateDelaySetting.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDelaySetting>.NativeClassPtr, nameof (From));
      DateDelaySetting.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateDelaySetting>.NativeClassPtr, nameof (To));
      DateDelaySetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateDelaySetting>.NativeClassPtr, 100665927);
    }

    public DateDelaySetting(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe DateDuration From
    {
      get
      {
        return *(DateDuration*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DateDelaySetting.NativeFieldInfoPtr_From));
      }
      [param: In] set
      {
        *(DateDuration*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DateDelaySetting.NativeFieldInfoPtr_From)) = value;
      }
    }

    public unsafe DateDuration To
    {
      get
      {
        return *(DateDuration*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DateDelaySetting.NativeFieldInfoPtr_To));
      }
      [param: In] set
      {
        *(DateDuration*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DateDelaySetting.NativeFieldInfoPtr_To)) = value;
      }
    }
  }
}
