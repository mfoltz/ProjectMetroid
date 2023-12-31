// Decompiled with JetBrains decompiler
// Type: ProjectM.HeightLevelCullingAuthoring
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
  public class HeightLevelCullingAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HeightOffset;
    private static readonly IntPtr NativeFieldInfoPtr_AlwaysCullAbove;
    private static readonly IntPtr NativeFieldInfoPtr_IsOccluder;
    private static readonly IntPtr NativeFieldInfoPtr_AddCullingToTileModel;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HeightLevelCullingAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeightLevelCullingAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HeightLevelCullingAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HeightLevelCullingAuthoring()
    {
      Il2CppClassPointerStore<HeightLevelCullingAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HeightLevelCullingAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeightLevelCullingAuthoring>.NativeClassPtr);
      HeightLevelCullingAuthoring.NativeFieldInfoPtr_HeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightLevelCullingAuthoring>.NativeClassPtr, nameof (HeightOffset));
      HeightLevelCullingAuthoring.NativeFieldInfoPtr_AlwaysCullAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightLevelCullingAuthoring>.NativeClassPtr, nameof (AlwaysCullAbove));
      HeightLevelCullingAuthoring.NativeFieldInfoPtr_IsOccluder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightLevelCullingAuthoring>.NativeClassPtr, nameof (IsOccluder));
      HeightLevelCullingAuthoring.NativeFieldInfoPtr_AddCullingToTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeightLevelCullingAuthoring>.NativeClassPtr, nameof (AddCullingToTileModel));
      HeightLevelCullingAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeightLevelCullingAuthoring>.NativeClassPtr, 100663845);
    }

    public HeightLevelCullingAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int HeightOffset
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeightLevelCullingAuthoring.NativeFieldInfoPtr_HeightOffset));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeightLevelCullingAuthoring.NativeFieldInfoPtr_HeightOffset)) = value;
      }
    }

    public unsafe bool AlwaysCullAbove
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeightLevelCullingAuthoring.NativeFieldInfoPtr_AlwaysCullAbove));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeightLevelCullingAuthoring.NativeFieldInfoPtr_AlwaysCullAbove)) = value;
      }
    }

    public unsafe bool IsOccluder
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeightLevelCullingAuthoring.NativeFieldInfoPtr_IsOccluder));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeightLevelCullingAuthoring.NativeFieldInfoPtr_IsOccluder)) = value;
      }
    }

    public unsafe bool AddCullingToTileModel
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeightLevelCullingAuthoring.NativeFieldInfoPtr_AddCullingToTileModel));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeightLevelCullingAuthoring.NativeFieldInfoPtr_AddCullingToTileModel)) = value;
      }
    }
  }
}
