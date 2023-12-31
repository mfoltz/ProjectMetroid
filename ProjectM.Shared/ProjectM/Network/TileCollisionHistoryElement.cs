// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.TileCollisionHistoryElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileCollisionHistoryElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_TileCollisionHistoryElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_TileCollisionHistoryElement_Byte_0;
    [FieldOffset(0)]
    public byte Value;

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator byte(TileCollisionHistoryElement e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHistoryElement.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_TileCollisionHistoryElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(59)]
    [CachedScanResults(RefRangeStart = 562577, RefRangeEnd = 562636, XrefRangeStart = 562577, XrefRangeEnd = 562636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator TileCollisionHistoryElement(byte e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileCollisionHistoryElement.NativeMethodInfoPtr_op_Implicit_Public_Static_TileCollisionHistoryElement_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileCollisionHistoryElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileCollisionHistoryElement()
    {
      Il2CppClassPointerStore<TileCollisionHistoryElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (TileCollisionHistoryElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileCollisionHistoryElement>.NativeClassPtr);
      TileCollisionHistoryElement.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileCollisionHistoryElement>.NativeClassPtr, nameof (Value));
      TileCollisionHistoryElement.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_TileCollisionHistoryElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHistoryElement>.NativeClassPtr, 100669229);
      TileCollisionHistoryElement.NativeMethodInfoPtr_op_Implicit_Public_Static_TileCollisionHistoryElement_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileCollisionHistoryElement>.NativeClassPtr, 100669230);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileCollisionHistoryElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
