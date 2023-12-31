// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.BitCellEnumerator
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BitCellEnumerator
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginalMask2D;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSubCell;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubCellIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Current;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;
    [FieldOffset(0)]
    public BitMask2D_16x16 OriginalMask2D;
    [FieldOffset(32)]
    public BitField64 CurrentSubCell;
    [FieldOffset(40)]
    public byte SubCellIndex;
    [FieldOffset(44)]
    public int2 Current;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 791714, XrefRangeEnd = 791715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool MoveNext()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BitCellEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BitCellEnumerator()
    {
      Il2CppClassPointerStore<BitCellEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (BitCellEnumerator));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitCellEnumerator>.NativeClassPtr);
      BitCellEnumerator.NativeFieldInfoPtr_OriginalMask2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCellEnumerator>.NativeClassPtr, nameof (OriginalMask2D));
      BitCellEnumerator.NativeFieldInfoPtr_CurrentSubCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCellEnumerator>.NativeClassPtr, nameof (CurrentSubCell));
      BitCellEnumerator.NativeFieldInfoPtr_SubCellIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCellEnumerator>.NativeClassPtr, nameof (SubCellIndex));
      BitCellEnumerator.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCellEnumerator>.NativeClassPtr, nameof (Current));
      BitCellEnumerator.NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCellEnumerator>.NativeClassPtr, 100669648);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitCellEnumerator>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
