// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileDatas2dArray`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  public struct TileDatas2dArray<T> where T : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TileDatas;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilesExists;
    private static readonly System.IntPtr NativeFieldInfoPtr_LocalBounds;
    public BlobArray<T> TileDatas;
    public BlobArray<bool> TilesExists;
    public BoundsMinMax LocalBounds;

    static TileDatas2dArray()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<TileDatas2dArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", "TileDatas2dArray`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDatas2dArray<T>>.NativeClassPtr);
      TileDatas2dArray<T>.NativeFieldInfoPtr_TileDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatas2dArray<T>>.NativeClassPtr, nameof (TileDatas));
      TileDatas2dArray<T>.NativeFieldInfoPtr_TilesExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatas2dArray<T>>.NativeClassPtr, nameof (TilesExists));
      TileDatas2dArray<T>.NativeFieldInfoPtr_LocalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatas2dArray<T>>.NativeClassPtr, nameof (LocalBounds));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileDatas2dArray<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public struct TempDataStruct
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Data;
      private static readonly System.IntPtr NativeFieldInfoPtr_Exists;
      public T Data;
      public bool Exists;

      static TempDataStruct()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<TileDatas2dArray<T>.TempDataStruct>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileDatas2dArray<T>>.NativeClassPtr, nameof (TempDataStruct<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDatas2dArray<T>.TempDataStruct>.NativeClassPtr);
        TileDatas2dArray<T>.TempDataStruct.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatas2dArray<T>.TempDataStruct>.NativeClassPtr, nameof (Data));
        TileDatas2dArray<T>.TempDataStruct.NativeFieldInfoPtr_Exists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDatas2dArray<T>.TempDataStruct>.NativeClassPtr, nameof (Exists));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileDatas2dArray<T>.TempDataStruct>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
