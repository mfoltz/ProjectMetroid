﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.DebugWorldCastleAreaBounds
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DebugWorldCastleAreaBounds
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TileRange;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TileRangeProperty_Public_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TileRangeProperty_Public_Virtual_Final_New_set_Void_Int32_0;
    [FieldOffset(0)]
    public int TileRange;

    public virtual unsafe int TileRangeProperty
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugWorldCastleAreaBounds.NativeMethodInfoPtr_get_TileRangeProperty_Public_Virtual_Final_New_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugWorldCastleAreaBounds.NativeMethodInfoPtr_set_TileRangeProperty_Public_Virtual_Final_New_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static DebugWorldCastleAreaBounds()
    {
      Il2CppClassPointerStore<DebugWorldCastleAreaBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM", nameof (DebugWorldCastleAreaBounds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugWorldCastleAreaBounds>.NativeClassPtr);
      DebugWorldCastleAreaBounds.NativeFieldInfoPtr_TileRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugWorldCastleAreaBounds>.NativeClassPtr, nameof (TileRange));
      DebugWorldCastleAreaBounds.NativeMethodInfoPtr_get_TileRangeProperty_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWorldCastleAreaBounds>.NativeClassPtr, 100663422);
      DebugWorldCastleAreaBounds.NativeMethodInfoPtr_set_TileRangeProperty_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugWorldCastleAreaBounds>.NativeClassPtr, 100663423);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugWorldCastleAreaBounds>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
