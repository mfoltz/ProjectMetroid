// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleRoom
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleRoom
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsMissingWalls;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasRoof;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnclosedRoom_Public_get_Boolean_0;
    [FieldOffset(0)]
    public bool IsMissingWalls;
    [FieldOffset(1)]
    public bool HasRoof;

    public unsafe bool IsEnclosedRoom
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 1127404, RefRangeEnd = 1127409, XrefRangeStart = 1127404, XrefRangeEnd = 1127404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleRoom.NativeMethodInfoPtr_get_IsEnclosedRoom_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static CastleRoom()
    {
      Il2CppClassPointerStore<CastleRoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleRoom));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRoom>.NativeClassPtr);
      CastleRoom.NativeFieldInfoPtr_IsMissingWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoom>.NativeClassPtr, nameof (IsMissingWalls));
      CastleRoom.NativeFieldInfoPtr_HasRoof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoom>.NativeClassPtr, nameof (HasRoof));
      CastleRoom.NativeMethodInfoPtr_get_IsEnclosedRoom_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleRoom>.NativeClassPtr, 100689572);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRoom>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
