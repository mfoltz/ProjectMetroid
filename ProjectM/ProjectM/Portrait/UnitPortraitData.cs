// Decompiled with JetBrains decompiler
// Type: ProjectM.Portrait.UnitPortraitData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Portrait
{
  [Serializable]
  public class UnitPortraitData : PortraitData
  {
    private static readonly IntPtr NativeFieldInfoPtr_CurrentAnimationTime;
    private static readonly IntPtr NativeFieldInfoPtr_CurrentClipIndex;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114672, XrefRangeEnd = 1114673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitPortraitData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitPortraitData>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitPortraitData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitPortraitData()
    {
      Il2CppClassPointerStore<UnitPortraitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Portrait", nameof (UnitPortraitData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitPortraitData>.NativeClassPtr);
      UnitPortraitData.NativeFieldInfoPtr_CurrentAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPortraitData>.NativeClassPtr, nameof (CurrentAnimationTime));
      UnitPortraitData.NativeFieldInfoPtr_CurrentClipIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPortraitData>.NativeClassPtr, nameof (CurrentClipIndex));
      UnitPortraitData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPortraitData>.NativeClassPtr, 100688236);
    }

    public UnitPortraitData(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float CurrentAnimationTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitPortraitData.NativeFieldInfoPtr_CurrentAnimationTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitPortraitData.NativeFieldInfoPtr_CurrentAnimationTime)) = value;
      }
    }

    public unsafe int CurrentClipIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitPortraitData.NativeFieldInfoPtr_CurrentClipIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitPortraitData.NativeFieldInfoPtr_CurrentClipIndex)) = value;
      }
    }
  }
}
