// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridNPCCustomizationTagComponent
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
namespace ProjectM.Hybrid
{
  public class HybridNPCCustomizationTagComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_NPCCustomizationTags;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridNPCCustomizationTagComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridNPCCustomizationTagComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridNPCCustomizationTagComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridNPCCustomizationTagComponent()
    {
      Il2CppClassPointerStore<HybridNPCCustomizationTagComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (HybridNPCCustomizationTagComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridNPCCustomizationTagComponent>.NativeClassPtr);
      HybridNPCCustomizationTagComponent.NativeFieldInfoPtr_NPCCustomizationTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridNPCCustomizationTagComponent>.NativeClassPtr, nameof (NPCCustomizationTags));
      HybridNPCCustomizationTagComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridNPCCustomizationTagComponent>.NativeClassPtr, 100670301);
    }

    public HybridNPCCustomizationTagComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HybridRendererNPCCustomizationTagEnum NPCCustomizationTags
    {
      get
      {
        return *(HybridRendererNPCCustomizationTagEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridNPCCustomizationTagComponent.NativeFieldInfoPtr_NPCCustomizationTags));
      }
      [param: In] set
      {
        *(HybridRendererNPCCustomizationTagEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridNPCCustomizationTagComponent.NativeFieldInfoPtr_NPCCustomizationTags)) = value;
      }
    }
  }
}
