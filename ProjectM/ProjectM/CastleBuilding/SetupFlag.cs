// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.SetupFlag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [Serializable]
  public class SetupFlag : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DyeMeshIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_RenderMeshIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_UdimIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetupFlag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupFlag>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupFlag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetupFlag()
    {
      Il2CppClassPointerStore<SetupFlag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (SetupFlag));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupFlag>.NativeClassPtr);
      SetupFlag.NativeFieldInfoPtr_DyeMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupFlag>.NativeClassPtr, nameof (DyeMeshIndex));
      SetupFlag.NativeFieldInfoPtr_RenderMeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupFlag>.NativeClassPtr, nameof (RenderMeshIndex));
      SetupFlag.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupFlag>.NativeClassPtr, nameof (MaterialIndex));
      SetupFlag.NativeFieldInfoPtr_UdimIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupFlag>.NativeClassPtr, nameof (UdimIndex));
      SetupFlag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupFlag>.NativeClassPtr, 100689734);
    }

    public SetupFlag(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int DyeMeshIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupFlag.NativeFieldInfoPtr_DyeMeshIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupFlag.NativeFieldInfoPtr_DyeMeshIndex)) = value;
      }
    }

    public unsafe int RenderMeshIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupFlag.NativeFieldInfoPtr_RenderMeshIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupFlag.NativeFieldInfoPtr_RenderMeshIndex)) = value;
      }
    }

    public unsafe int MaterialIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupFlag.NativeFieldInfoPtr_MaterialIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupFlag.NativeFieldInfoPtr_MaterialIndex)) = value;
      }
    }

    public unsafe int UdimIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupFlag.NativeFieldInfoPtr_UdimIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupFlag.NativeFieldInfoPtr_UdimIndex)) = value;
      }
    }
  }
}
