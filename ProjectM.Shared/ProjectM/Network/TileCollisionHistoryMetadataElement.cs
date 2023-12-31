// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.TileCollisionHistoryMetadataElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileCollisionHistoryMetadataElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TilePosition;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_int2_TileCollisionHistoryMetadataElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TileCollisionHistoryMetadataElement_int2_0;
    [FieldOffset(0)]
    public int2 TilePosition;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator int2(TileCollisionHistoryMetadataElement e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHistoryMetadataElement.NativeMethodInfoPtr_op_Implicit_Public_Static_int2_TileCollisionHistoryMetadataElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator TileCollisionHistoryMetadataElement(int2 e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHistoryMetadataElement.NativeMethodInfoPtr_op_Implicit_Public_Static_TileCollisionHistoryMetadataElement_int2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCollisionHistoryMetadataElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileCollisionHistoryMetadataElement()
    {
      Il2CppClassPointerStore<TileCollisionHistoryMetadataElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (TileCollisionHistoryMetadataElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCollisionHistoryMetadataElement>.NativeClassPtr);
      TileCollisionHistoryMetadataElement.NativeFieldInfoPtr_TilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCollisionHistoryMetadataElement>.NativeClassPtr, nameof (TilePosition));
      TileCollisionHistoryMetadataElement.NativeMethodInfoPtr_op_Implicit_Public_Static_int2_TileCollisionHistoryMetadataElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHistoryMetadataElement>.NativeClassPtr, 100669231);
      TileCollisionHistoryMetadataElement.NativeMethodInfoPtr_op_Implicit_Public_Static_TileCollisionHistoryMetadataElement_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHistoryMetadataElement>.NativeClassPtr, 100669232);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCollisionHistoryMetadataElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
