// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.OffsetData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [Serializable]
  public class OffsetData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OffsetData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffsetData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OffsetData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OffsetData()
    {
      Il2CppClassPointerStore<OffsetData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (OffsetData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetData>.NativeClassPtr);
      OffsetData.NativeFieldInfoPtr_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetData>.NativeClassPtr, nameof (StartIndex));
      OffsetData.NativeFieldInfoPtr_NumFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetData>.NativeClassPtr, nameof (NumFlags));
      OffsetData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetData>.NativeClassPtr, 100689735);
    }

    public OffsetData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int StartIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OffsetData.NativeFieldInfoPtr_StartIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OffsetData.NativeFieldInfoPtr_StartIndex)) = value;
      }
    }

    public unsafe int NumFlags
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OffsetData.NativeFieldInfoPtr_NumFlags));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OffsetData.NativeFieldInfoPtr_NumFlags)) = value;
      }
    }
  }
}
