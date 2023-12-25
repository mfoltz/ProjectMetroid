// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.BlackboardMappingCategoryFilterAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class BlackboardMappingCategoryFilterAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Category;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Category_Public_get_BlackboardParameterCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlackboardParameterCategory_0;

    public unsafe BlackboardParameterCategory Category
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlackboardMappingCategoryFilterAttribute.NativeMethodInfoPtr_get_Category_Public_get_BlackboardParameterCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BlackboardParameterCategory*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 73013, RefRangeEnd = 73032, XrefRangeStart = 73013, XrefRangeEnd = 73032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlackboardMappingCategoryFilterAttribute(BlackboardParameterCategory category)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackboardMappingCategoryFilterAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &category;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlackboardMappingCategoryFilterAttribute.NativeMethodInfoPtr__ctor_Public_Void_BlackboardParameterCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlackboardMappingCategoryFilterAttribute()
    {
      Il2CppClassPointerStore<BlackboardMappingCategoryFilterAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (BlackboardMappingCategoryFilterAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackboardMappingCategoryFilterAttribute>.NativeClassPtr);
      BlackboardMappingCategoryFilterAttribute.NativeFieldInfoPtr__Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardMappingCategoryFilterAttribute>.NativeClassPtr, nameof (_Category));
      BlackboardMappingCategoryFilterAttribute.NativeMethodInfoPtr_get_Category_Public_get_BlackboardParameterCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardMappingCategoryFilterAttribute>.NativeClassPtr, 100686415);
      BlackboardMappingCategoryFilterAttribute.NativeMethodInfoPtr__ctor_Public_Void_BlackboardParameterCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardMappingCategoryFilterAttribute>.NativeClassPtr, 100686416);
    }

    public BlackboardMappingCategoryFilterAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BlackboardParameterCategory _Category
    {
      get
      {
        return *(BlackboardParameterCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardMappingCategoryFilterAttribute.NativeFieldInfoPtr__Category));
      }
      [param: In] set
      {
        *(BlackboardParameterCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardMappingCategoryFilterAttribute.NativeFieldInfoPtr__Category)) = value;
      }
    }
  }
}
