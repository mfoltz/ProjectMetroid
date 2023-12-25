// Decompiled with JetBrains decompiler
// Type: VBloodPortraitData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System.Runtime.InteropServices;

#nullable disable
public class VBloodPortraitData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_LargeStandard;
  private static readonly System.IntPtr NativeFieldInfoPtr_LargeEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_SmallStandard;
  private static readonly System.IntPtr NativeFieldInfoPtr_SmallEffect;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(4981)]
  [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodPortraitData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
  }

  [CallerCount(3875)]
  [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VBloodPortraitData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VBloodPortraitData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VBloodPortraitData()
  {
    Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (VBloodPortraitData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr);
    VBloodPortraitData.NativeFieldInfoPtr_LargeStandard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr, nameof (LargeStandard));
    VBloodPortraitData.NativeFieldInfoPtr_LargeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr, nameof (LargeEffect));
    VBloodPortraitData.NativeFieldInfoPtr_SmallStandard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr, nameof (SmallStandard));
    VBloodPortraitData.NativeFieldInfoPtr_SmallEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr, nameof (SmallEffect));
    VBloodPortraitData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr, 100663594);
    VBloodPortraitData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodPortraitData>.NativeClassPtr, 100663595);
  }

  public VBloodPortraitData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AssetGuid LargeStandard
  {
    get
    {
      return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitData.NativeFieldInfoPtr_LargeStandard));
    }
    [param: In] set
    {
      *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitData.NativeFieldInfoPtr_LargeStandard)) = value;
    }
  }

  public unsafe AssetGuid LargeEffect
  {
    get
    {
      return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitData.NativeFieldInfoPtr_LargeEffect));
    }
    [param: In] set
    {
      *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitData.NativeFieldInfoPtr_LargeEffect)) = value;
    }
  }

  public unsafe AssetGuid SmallStandard
  {
    get
    {
      return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitData.NativeFieldInfoPtr_SmallStandard));
    }
    [param: In] set
    {
      *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitData.NativeFieldInfoPtr_SmallStandard)) = value;
    }
  }

  public unsafe AssetGuid SmallEffect
  {
    get
    {
      return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitData.NativeFieldInfoPtr_SmallEffect));
    }
    [param: In] set
    {
      *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodPortraitData.NativeFieldInfoPtr_SmallEffect)) = value;
    }
  }
}
