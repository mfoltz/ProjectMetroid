// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.UseHybridModel
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Hybrid
{
  public class UseHybridModel : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr_Override;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkinColorCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseSkinColorCollection;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 796743, XrefRangeEnd = 796752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseHybridModel.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UseHybridModel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseHybridModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UseHybridModel()
    {
      Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Hybrid", nameof (UseHybridModel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr);
      UseHybridModel.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr, nameof (Prefabs));
      UseHybridModel.NativeFieldInfoPtr_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr, nameof (Override));
      UseHybridModel.NativeFieldInfoPtr_SkinColorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr, nameof (SkinColorCollection));
      UseHybridModel.NativeFieldInfoPtr_UseSkinColorCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr, nameof (UseSkinColorCollection));
      UseHybridModel.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr, 100670302);
      UseHybridModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseHybridModel>.NativeClassPtr, 100670303);
    }

    public UseHybridModel(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<AssetGuid> Prefabs
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModel.NativeFieldInfoPtr_Prefabs));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<AssetGuid>) null : new Il2CppStructArray<AssetGuid>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModel.NativeFieldInfoPtr_Prefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AssetGuid Override
    {
      get
      {
        return *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModel.NativeFieldInfoPtr_Override));
      }
      [param: In] set
      {
        *(AssetGuid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModel.NativeFieldInfoPtr_Override)) = value;
      }
    }

    public unsafe NPCServantSkinColorCollection SkinColorCollection
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModel.NativeFieldInfoPtr_SkinColorCollection));
        return pointer == System.IntPtr.Zero ? (NPCServantSkinColorCollection) null : new NPCServantSkinColorCollection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModel.NativeFieldInfoPtr_SkinColorCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool UseSkinColorCollection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModel.NativeFieldInfoPtr_UseSkinColorCollection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseHybridModel.NativeFieldInfoPtr_UseSkinColorCollection)) = value;
      }
    }
  }
}
