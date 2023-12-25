// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AdditionalMaterialData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AdditionalMaterialData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalMaterials;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_AdditionalMaterialData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<AdditionalMaterialOutput> AdditionalMaterials;
    [FieldOffset(16)]
    public NativeList<Entity> Entities;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107314, RefRangeEnd = 1107316, XrefRangeStart = 1107308, XrefRangeEnd = 1107314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AdditionalMaterialData(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107322, RefRangeEnd = 1107323, XrefRangeStart = 1107316, XrefRangeEnd = 1107322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialData.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107341, RefRangeEnd = 1107342, XrefRangeStart = 1107323, XrefRangeEnd = 1107341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyFrom(AdditionalMaterialData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialData.NativeMethodInfoPtr_CopyFrom_Public_Void_AdditionalMaterialData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107348, RefRangeEnd = 1107350, XrefRangeStart = 1107342, XrefRangeEnd = 1107348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdditionalMaterialData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AdditionalMaterialData()
    {
      Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AdditionalMaterialData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr);
      AdditionalMaterialData.NativeFieldInfoPtr_AdditionalMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr, nameof (AdditionalMaterials));
      AdditionalMaterialData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr, nameof (Entities));
      AdditionalMaterialData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr, 100687721);
      AdditionalMaterialData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr, 100687722);
      AdditionalMaterialData.NativeMethodInfoPtr_CopyFrom_Public_Void_AdditionalMaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr, 100687723);
      AdditionalMaterialData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr, 100687724);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalMaterialData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
