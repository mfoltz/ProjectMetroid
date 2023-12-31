// Decompiled with JetBrains decompiler
// Type: ProjectM.VolumeCompanion
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM
{
  public class VolumeCompanion : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlendDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Profile;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VolumeCompanion.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VolumeCompanion()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VolumeCompanion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VolumeCompanion()
    {
      Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (VolumeCompanion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr);
      VolumeCompanion.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr, nameof (Priority));
      VolumeCompanion.NativeFieldInfoPtr_BlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr, nameof (BlendDistance));
      VolumeCompanion.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr, nameof (Weight));
      VolumeCompanion.NativeFieldInfoPtr_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr, nameof (Profile));
      VolumeCompanion.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr, nameof (Name));
      VolumeCompanion.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr, 100664714);
      VolumeCompanion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeCompanion>.NativeClassPtr, 100664715);
    }

    public VolumeCompanion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Priority
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_Priority));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_Priority)) = value;
      }
    }

    public unsafe float BlendDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_BlendDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_BlendDistance)) = value;
      }
    }

    public unsafe float Weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_Weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_Weight)) = value;
      }
    }

    public unsafe VolumeProfile Profile
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_Profile));
        return pointer == System.IntPtr.Zero ? (VolumeProfile) null : new VolumeProfile(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_Profile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VolumeCompanion.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
