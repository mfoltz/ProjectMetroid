// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModelLayer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Tiles
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TileModelLayer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelLayer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public TileModelLayerEnum Layer;

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 731961, RefRangeEnd = 731976, XrefRangeStart = 731961, XrefRangeEnd = 731976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(TileModelLayer other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelLayer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelLayer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790420, XrefRangeEnd = 790421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelLayer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TileModelLayer()
    {
      Il2CppClassPointerStore<TileModelLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileModelLayer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelLayer>.NativeClassPtr);
      TileModelLayer.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelLayer>.NativeClassPtr, nameof (Layer));
      TileModelLayer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TileModelLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelLayer>.NativeClassPtr, 100669533);
      TileModelLayer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelLayer>.NativeClassPtr, 100669534);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelLayer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
