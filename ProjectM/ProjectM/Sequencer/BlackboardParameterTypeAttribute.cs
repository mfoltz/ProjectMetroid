// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.BlackboardParameterTypeAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class BlackboardParameterTypeAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Type;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_BlackboardRegisterType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlackboardRegisterType_0;

    public unsafe BlackboardRegisterType Type
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlackboardParameterTypeAttribute.NativeMethodInfoPtr_get_Type_Public_get_BlackboardRegisterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BlackboardRegisterType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(19)]
    [CachedScanResults(RefRangeStart = 73013, RefRangeEnd = 73032, XrefRangeStart = 73013, XrefRangeEnd = 73032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlackboardParameterTypeAttribute(BlackboardRegisterType type)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackboardParameterTypeAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlackboardParameterTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_BlackboardRegisterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BlackboardParameterTypeAttribute()
    {
      Il2CppClassPointerStore<BlackboardParameterTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (BlackboardParameterTypeAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackboardParameterTypeAttribute>.NativeClassPtr);
      BlackboardParameterTypeAttribute.NativeFieldInfoPtr__Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameterTypeAttribute>.NativeClassPtr, nameof (_Type));
      BlackboardParameterTypeAttribute.NativeMethodInfoPtr_get_Type_Public_get_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameterTypeAttribute>.NativeClassPtr, 100686738);
      BlackboardParameterTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_BlackboardRegisterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameterTypeAttribute>.NativeClassPtr, 100686739);
    }

    public BlackboardParameterTypeAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BlackboardRegisterType _Type
    {
      get
      {
        return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterTypeAttribute.NativeFieldInfoPtr__Type));
      }
      [param: In] set
      {
        *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterTypeAttribute.NativeFieldInfoPtr__Type)) = value;
      }
    }
  }
}
