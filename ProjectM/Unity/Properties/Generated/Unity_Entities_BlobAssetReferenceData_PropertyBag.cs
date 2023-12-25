// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.Unity_Entities_BlobAssetReferenceData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;

#nullable disable
namespace Unity.Properties.Generated
{
  public class Unity_Entities_BlobAssetReferenceData_PropertyBag : 
    ContainerPropertyBag<BlobAssetReferenceData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1172067, RefRangeEnd = 1172068, XrefRangeStart = 1172054, XrefRangeEnd = 1172067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Unity_Entities_BlobAssetReferenceData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Entities_BlobAssetReferenceData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Unity_Entities_BlobAssetReferenceData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Unity_Entities_BlobAssetReferenceData_PropertyBag()
    {
      Il2CppClassPointerStore<Unity_Entities_BlobAssetReferenceData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (Unity_Entities_BlobAssetReferenceData_PropertyBag));
      Unity_Entities_BlobAssetReferenceData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Entities_BlobAssetReferenceData_PropertyBag>.NativeClassPtr, 100693536);
    }

    public Unity_Entities_BlobAssetReferenceData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class SerializedHash : ReflectedMemberProperty<BlobAssetReferenceData, long>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1172053, RefRangeEnd = 1172054, XrefRangeStart = 1172039, XrefRangeEnd = 1172053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SerializedHash()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unity_Entities_BlobAssetReferenceData_PropertyBag.SerializedHash>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Unity_Entities_BlobAssetReferenceData_PropertyBag.SerializedHash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SerializedHash()
      {
        Il2CppClassPointerStore<Unity_Entities_BlobAssetReferenceData_PropertyBag.SerializedHash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Unity_Entities_BlobAssetReferenceData_PropertyBag>.NativeClassPtr, nameof (SerializedHash));
        Unity_Entities_BlobAssetReferenceData_PropertyBag.SerializedHash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unity_Entities_BlobAssetReferenceData_PropertyBag.SerializedHash>.NativeClassPtr, 100693537);
      }

      public SerializedHash(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
