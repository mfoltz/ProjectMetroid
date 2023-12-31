// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementConfigAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  public class PlacementConfigAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Attachable;
    private static readonly System.IntPtr NativeFieldInfoPtr_Replaceable;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790028, RefRangeEnd = 790030, XrefRangeStart = 790027, XrefRangeEnd = 790028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlacementConfigAttribute()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlacementConfigAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementConfigAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlacementConfigAttribute()
    {
      Il2CppClassPointerStore<PlacementConfigAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (PlacementConfigAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementConfigAttribute>.NativeClassPtr);
      PlacementConfigAttribute.NativeFieldInfoPtr_Attachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementConfigAttribute>.NativeClassPtr, nameof (Attachable));
      PlacementConfigAttribute.NativeFieldInfoPtr_Replaceable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementConfigAttribute>.NativeClassPtr, nameof (Replaceable));
      PlacementConfigAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementConfigAttribute>.NativeClassPtr, 100669516);
    }

    public PlacementConfigAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Attachable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlacementConfigAttribute.NativeFieldInfoPtr_Attachable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlacementConfigAttribute.NativeFieldInfoPtr_Attachable)) = value;
      }
    }

    public unsafe bool Replaceable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlacementConfigAttribute.NativeFieldInfoPtr_Replaceable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlacementConfigAttribute.NativeFieldInfoPtr_Replaceable)) = value;
      }
    }
  }
}
